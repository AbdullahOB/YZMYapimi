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
    public partial class Düzeltme_Form : Form
    {
        public Düzeltme_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaticiForm satici = new SaticiForm();
            satici.Show();

        }
    }
}
