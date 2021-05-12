using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using YZMYapimiProjesi.DB;
using YZMYapimiProjesi.Login;

namespace YZMYapimiProjesi.Alici
{
    public partial class AliciForm : Form
    {
        private readonly DbEntity _db;
        private YaziSartlari sart;
        public LoginForm _login;
        public string _ad;
        public int _walletBalance;
        public int _id, _id2;

        public AliciForm(LoginForm login, string Ad, int walletBalance, int id)
        {
            InitializeComponent();
            _db = new DbEntity();
            _login = login;
            _ad = Ad;
            _walletBalance = walletBalance;
            _id = id;
        }

        public AliciForm()
        {
            InitializeComponent();
        }

        private void PBimageGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.LoginForm log = new Login.LoginForm();
            log.Show();
        }

        private void TbMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart = new YaziSartlari();
            sart.AllowNumberOnly(e, TbMiktar, errorProviderMiktar);
        }

        private void btnParaYukle_Click(object sender, EventArgs e)
        {
            var formPopup = new ParaEkleForm(_id, _ad);
            formPopup.Show();
        }

        private void PbRefresh_Click(object sender, EventArgs e)
        {
            var user = _db.KullaniciTables.Find(_id);

            lblPara.Text = user.WalletBalance.ToString();
        }

        private void AliciForm_Load(object sender, EventArgs e)
        {
            lblName.Text = _ad;

            lblPara.Text = _walletBalance.ToString();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            if (_db.SaticiVarliklari.Count() != 0)
            {
                int urnMik = Convert.ToInt32(TbMiktar.Text);
                var Alici = _db.KullaniciTables.FirstOrDefault(q => q.Id == _id);
                var saticiMinFiyat = _db.SaticiVarliklari.OrderBy(d => d.urnFiyat);
                foreach (var l in saticiMinFiyat)
                {
                    if (l.urnAdi == CbUrun.Text)
                    {
                        var Satici = _db.KullaniciTables.FirstOrDefault(p => p.Id == l.KullaniciId);
                        var alim = _db.AlimSatimIslemler.Create();
                        alim.AliciId = _id;
                        alim.AliciAdi = Alici.KullaniciAdi;
                        alim.SaticiId = l.KullaniciId;
                        alim.SaticiAdi = l.KullaniciId.ToString();
                        alim.Fiyat = l.urnFiyat;
                        if (l.urnMiktari > 0)
                        {
                            if (Alici.WalletBalance > urnMik * Convert.ToInt32(l.urnFiyat))
                            {
                                if (urnMik > l.urnMiktari)
                                {
                                    alim.Miktar = l.urnMiktari;
                                    urnMik -= alim.Miktar;
                                    Satici.WalletBalance = Satici.WalletBalance + (alim.Miktar * Convert.ToInt32(l.urnFiyat));
                                    Alici.WalletBalance = Alici.WalletBalance - (alim.Miktar * Convert.ToInt32(l.urnFiyat));
                                    l.urnMiktari = 0;
                                }
                                if (urnMik < l.urnMiktari)
                                {
                                    alim.Miktar = urnMik;
                                    l.urnMiktari = l.urnMiktari - urnMik;
                                    Satici.WalletBalance = Satici.WalletBalance + (alim.Miktar * Convert.ToInt32(l.urnFiyat));
                                    Alici.WalletBalance = Alici.WalletBalance - (alim.Miktar * Convert.ToInt32(l.urnFiyat));
                                    urnMik = 0;
                                }
                                if (l.urnMiktari == 0)
                                {
                                    _db.SaticiVarliklari.Remove(l);
                                }

                                _db.AlimSatimIslemler.Add(alim);

                                if (alim.Miktar == 0)
                                {
                                    _db.AlimSatimIslemler.Remove(alim);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Cüzdanınızda Para Kalmadı");
                                break;
                            }

                           
                        }
                    }
                }
                _db.SaveChanges();

                // var saticiAdiFromKull = _db.KullaniciTables.FirstOrDefault(q => q.KullaniciTipi == "Satici");
                // var saticiAdi = saticiAdiFromKull.Ad;
                // var saticiId = saticiAdiFromKull.Id;

                // var alimSatim = _db.AlimSatimIslemler.Create();
                // alimSatim.AliciAdi = _ad;
                // alimSatim.AliciId = _id;
                // alimSatim.SaticiId = saticiId;
                // alimSatim.SaticiAdi = saticiAdi;
                // alimSatim.Miktar = satici.urnMiktari;
                //// alimSatim.Fiyat = min;
                // _db.AlimSatimIslemler.Add(alimSatim);
                // _db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Şuanda Herhangi Bir Satici Yoktur...");
            }

            AlimRapor rpr = new AlimRapor(CbUrun.Text, Convert.ToInt32(TbMiktar.Text));
            rpr.Show();
        }
    }
}