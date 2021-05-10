using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZMYapimiProjesi.Satici
{
    public partial class SaticiForm : Form
    {
        public SaticiForm()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.LoginForm obj = new Login.LoginForm();
            obj.Show();
        }

        private void UrunEkbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UrunEkForm obj = new UrunEkForm();
            obj.Show();
            
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SaticiForm_Load(object sender, EventArgs e)
        {
            
            
        }

    }
}
