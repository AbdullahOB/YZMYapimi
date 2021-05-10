using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public AliciForm(LoginForm login, string Ad ,int walletBalance,int id)
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
            var req = _db.RequestTables.FirstOrDefault(q => q.KullaniciId == _id);
            var user = _db.KullaniciTables.Find(_id);
            if (req != null)
            {
                var statue = req.Statue.Id;
                var paraMiktari = req.ParaMiktari;
                
                if (statue == 1)
                {
                    MessageBox.Show(paraMiktari + " TL Olan Talebiniz Kabul Edilmistir!", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.WalletBalance += paraMiktari;
                    _db.RequestTables.Remove(req);
                }
                else if (statue == 2)
                {
                    MessageBox.Show(paraMiktari +" TL Olan Talebiniz Red Edilmistir!", "Red", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    user.WalletBalance += 0;
                    _db.RequestTables.Remove(req);
                }
                else
                {
                    MessageBox.Show("Geçmiş Talebleriniz Beklemede! Lütfen Daha Sonra Deneyniz", "Beklemede", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _db.SaveChanges();
                lblPara.Text = user.WalletBalance.ToString();
            }
            else
            {
                lblPara.Text = user.WalletBalance.ToString();
                MessageBox.Show("Paranız Güncellenmiştir !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void AliciForm_Load(object sender, EventArgs e)
        {
            lblName.Text = _ad;
            lblPara.Text = _walletBalance.ToString();
        }
        private void btnAl_Click(object sender, EventArgs e)
        {
            var user = _db.KullaniciTables.Find(_id);
            user.WalletBalance -= Convert.ToInt32(TbMiktar.Text);
            _db.SaveChanges();

            AlimRapor rpr = new AlimRapor(CbUrun.Text, Convert.ToInt32(TbMiktar.Text));
            rpr.Show();

        }




    }
}
