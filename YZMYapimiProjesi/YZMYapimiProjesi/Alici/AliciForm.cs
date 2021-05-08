using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZMYapimiProjesi.Alici
{
    public partial class AliciForm : Form
    {
        public void getName(string username)
        {
            lblName.Text = username;
        }
        
        public void getToplam(string toplam)
        {
            lblName.Text = toplam;
        }
        
         public AliciForm()
        {  
            InitializeComponent();
        }



        private void btnAl_Click(object sender, EventArgs e)
        {

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
    }
}
