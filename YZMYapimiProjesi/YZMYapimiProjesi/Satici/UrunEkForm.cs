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
    public partial class UrunEkForm : Form
    {
        public UrunEkForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaticiForm obj1 = new SaticiForm();
            obj1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void UrunEkForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Buğday");
            comboBox1.Items.Add("Yulaf");
            comboBox1.Items.Add("Pamuk");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            SaticiForm ek = new SaticiForm();
            if (ek.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of form2's TextBox. 
                ek.listBox2.Items.Add(textBox1.Text);
               
            }

            ek.Dispose();
        }
    }
}
