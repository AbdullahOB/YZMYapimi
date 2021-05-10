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
namespace YZMYapimiProjesi.Satici
{
    public partial class SaticiForm : Form
    {
        public int _id;
        public SaticiForm(int id)
        {
            _id = id;
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
            UrunEkForm obj = new UrunEkForm(_id);
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
