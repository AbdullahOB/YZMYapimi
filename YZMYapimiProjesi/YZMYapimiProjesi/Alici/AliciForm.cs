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
         public AliciForm(string userName)
        {  
            InitializeComponent();
            lblName.Text = userName;

        }


        public int Cuzdan;













        private void btnAl_Click(object sender, EventArgs e)
        {

        }

        private void PBimageGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.LoginForm log = new Login.LoginForm();
            log.Show();
        }

        public void AllowNumberOnly(KeyPressEventArgs e, TextBox txt, ErrorProvider err)
        {
            string Numbers = "0123456789" + "\b" + "\t";
            if (Numbers.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
                err.SetError(txt, "Sadece Rakam Girebilirsiniz!");
            }
            else
            {
                e.Handled = false;
                err.SetError(txt, "");
            }

        }

        private void TbMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumberOnly(e, TbMiktar , errorProviderMiktar);
        }

    }
}
