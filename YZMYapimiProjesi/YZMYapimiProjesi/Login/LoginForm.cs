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

namespace YZMYapimiProjesi.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.modelDataSet.Table);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Abdullah\OneDrive\Desktop\YZMYapimi\YZMYapimiProjesi\YZMYapimiProjesi\Database1.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [Table] where KullaniciAdi ='" + textBox1.Text + "' and Sifre = '" + textBox2.Text + "'" , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            
            
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Satici");
            }
            
            else
            {
                MessageBox.Show("Your Password Or Username is wrong");
            }
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void SaticiCheck(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpFormu sgnFrm = new SignUpFormu();
            sgnFrm.ShowDialog();
        }
    }
}
