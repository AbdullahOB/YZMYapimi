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
        public int _id;

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
            MessageBox.Show("S");

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

        private void button1_Click(object sender, EventArgs e)
        {
            var formPopup = new ParaEkleForm();
            formPopup.Show();
        }

       

        private void AliciForm_Load(object sender, EventArgs e)
        {
            lblName.Text = _ad;
            lblPara.Text = _walletBalance.ToString();
                
         
            
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var users = _db.KullaniciTables.Find(_id);
            lblPara.Text = users.WalletBalance.ToString();
        }
    }
}
