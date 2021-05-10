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
            var formPopup = new ParaEkleForm(_id , _ad);
            formPopup.Show();
        }

        private void PbRefresh_Click(object sender, EventArgs e)
        {
            // TODO: check if this is true use of new databse 
            DbEntity db2 = new DbEntity();
            var req = db2.RequestTables.FirstOrDefault(q => q.KullaniciId == _id);
            var statue = req.statueId;
            var paraMiktari = req.ParaMiktari;
            var user = db2.KullaniciTables.Find(_id);
            if (statue == 1)
            {
                user.WalletBalance += paraMiktari;
            }
            else if(statue == 2)
            {
                user.WalletBalance += 0;
            }
            

            lblPara.Text = user.WalletBalance.ToString();
            
        }

        private void AliciForm_Load(object sender, EventArgs e)
        {
            lblName.Text = _ad;

            lblPara.Text = _walletBalance.ToString();

        }


    }
}
