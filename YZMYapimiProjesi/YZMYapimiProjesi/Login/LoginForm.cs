using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using YZMYapimiProjesi.SignUp;
using YZMYapimiProjesi.Alici;
using YZMYapimiProjesi.Admin;
using YZMYapimiProjesi.Satici;
using YZMYapimiProjesi.DB;

namespace YZMYapimiProjesi.Login
{
    public partial class LoginForm : Form
    {
        private readonly DbEntity _db;
 
        public LoginForm()
        {
            InitializeComponent();
            _db = new DbEntity();
        }
        public LoginForm(string name)
        {
            InitializeComponent();
            _db = new DbEntity();
            textBox1.Text = name;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                var kullanici = textBox1.Text.Trim();
                var sifre = textBox2.Text;
                var user = _db.KullaniciTables.FirstOrDefault(q => q.KullaniciAdi == kullanici && q.Sifre == sifre);
                if(user == null)
                {
                    MessageBox.Show("Hatali Sifre Veya Kullanici Adi Girdiniz ...");
                }
                else
                {
                    var role = user.KullaniciRoles.FirstOrDefault();
                    var roleNm = role.Role.KullaniciTipi;
                    var userWallet = user.WalletBalance;
                    if (roleNm == "Admin")
                    {
                        this.Hide();
                        AdminAraYuzu admin = new AdminAraYuzu();
                        admin.Show();
                    }
                   else if (roleNm == "Satici")
                    {
                        this.Hide();
                        SaticiForm satici = new SaticiForm(user.Id);
                        satici.Show();
                    }
                   else if (roleNm == "Alici")
                    {
                        AliciForm alici = new AliciForm(this, user.Ad, Convert.ToInt32(userWallet) , user.Id);
                        
                        alici.Show();

                        Hide();
                    }
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpFormu sgnFrm = new SignUpFormu();
            sgnFrm.ShowDialog();
        }
    }
}
