using System;
using System.Data;
using System.Drawing;
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

        private void CbOnayla_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
 
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;


            DialogResult res = printDialog.ShowDialog();
            if (res == DialogResult.OK)
            {

                printDocument1.Print();

            }
            this.Hide();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var time = DateTime.Now;
            var userAdi = _db.AlimSatimIslemler.FirstOrDefault(q => q.AliciId == _id);
            e.Graphics.DrawString("Alım Satım Raporu ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString(userAdi.AliciAdi, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 10));
            e.Graphics.DrawString(time.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(700, 10));
            e.Graphics.DrawString("_____________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 60));


            var alimSatimIslem = _db.AlimSatimIslemler.OrderByDescending(q => q.islemZamani);
            var fnt = new Font("Arial", 6, FontStyle.Bold);
            int x = 100, y = 100;
            int dy = (int)fnt.GetHeight(e.Graphics) * 1;
            int t = 0;
            foreach (var l in alimSatimIslem)
            {
                if (l.AliciId == _id)
                {


                    e.Graphics.DrawString("Alınan Ürün: " + l.urnAdi + ", Ürün Mıktarı: " + l.Miktar + " (KG) " + ", Aliş Fiyatı: " + l.Fiyat + " (TL) " + ", Alıcı Adi: " + l.AliciAdi + ", Alıcı ID: " + l.AliciId + ", Satıcı Adı: " + l.SaticiAdi + ", Satıcı ID: " + l.SaticiId + ", İşlem Zamanı : " + l.islemZamani.ToString(), fnt, Brushes.Black, new Point(x, y)); y += dy;
                    e.Graphics.DrawString("__________________________________________________________________________________________________________________________", fnt, Brushes.Black, new Point(x, y)); y += dy;
                    t++;
                }

            }

        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            int islemSayi = 0;
            if(CbOnayla.CheckState == CheckState.Checked)
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
                            alim.SaticiAdi = l.KullaniciTable.Ad.ToString();
                            alim.urnAdi = l.urnAdi;
                            alim.Fiyat = l.urnFiyat;
                            alim.islemZamani = DateTime.Now;
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
                                        islemSayi++;
                                    }
                                    if (urnMik <= l.urnMiktari)
                                    {
                                        alim.Miktar = urnMik;
                                        l.urnMiktari = l.urnMiktari - urnMik;
                                        Satici.WalletBalance = Satici.WalletBalance + (alim.Miktar * Convert.ToInt32(l.urnFiyat));
                                        Alici.WalletBalance = Alici.WalletBalance - (alim.Miktar * Convert.ToInt32(l.urnFiyat));
                                        urnMik = 0;
                                        islemSayi++;
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
                                   
                                    MessageBox.Show("Cüzdanınızda Yeterli Paranız Yoktur..", "Alim Islemi Başarsız", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    break;
                                }


                            }
                        }

                    }
                    _db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Şuanda Herhangi Bir Satici Yoktur...", "Alim Islemi Başarsız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("Alim Islemi Başarıyla Gerçekleşti ...", "Alim Islemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlimRapor alimRapor = new AlimRapor(_id ,islemSayi);
                alimRapor.Show();

            }
            else
            {
                MessageBox.Show("Onaylıyorum kısmını işaretleyiniz!", "Alim Islemi Başarsız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            

            

        }
    }
}