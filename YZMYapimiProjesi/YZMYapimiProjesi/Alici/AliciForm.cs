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
        private readonly DBEntity1 _db;
        public LoginForm _login;
        public string _ad;
        public int _walletBalance;
        public int _id, _id2;

        public AliciForm(LoginForm login, string Ad ,int walletBalance,int id)
        {
            InitializeComponent();
            _db = new DBEntity1();
            _login = login;
            _ad = Ad;
            _walletBalance = walletBalance;
            _id = id;
            
        }

         public AliciForm()
        {
          
            InitializeComponent();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            var user = _db.KullaniciTables.Find(_id);
            user.WalletBalance -= Convert.ToInt32(TbMiktar.Text);
            _db.SaveChanges();
        }

        private void PBimageGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.LoginForm log = new Login.LoginForm();
            log.Show();
        }


        readonly YaziSartlari sart = new YaziSartlari();

        private void TbMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.AllowNumberOnly(e, TbMiktar , errorProviderMiktar);
        }

        private void btnParaYukle_Click(object sender, EventArgs e)
        {
            var formPopup = new ParaEkleForm(_id);
            formPopup.Show();
        }

        private void PbRefresh_Click(object sender, EventArgs e)
        {
            // TODO: check if this is true use of new databse 
            DBEntity1 db2 = new DBEntity1();
            var user = db2.KullaniciTables.Find(_id);
            lblPara.Text = user.WalletBalance.ToString();
        }

        private void AliciForm_Load(object sender, EventArgs e)
        {
            lblName.Text = _ad;
            lblPara.Text = _walletBalance.ToString();
        }


    }
}
