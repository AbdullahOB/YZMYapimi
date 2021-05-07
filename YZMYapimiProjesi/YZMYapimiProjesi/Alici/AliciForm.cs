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

        private void btnAl_Click(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
