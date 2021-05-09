using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZMYapimiProjesi.Alici
{
    public partial class ParaEkleForm : Form
    {
        private int Toplam;

        public ParaEkleForm()
        {
            InitializeComponent();
        }
        private int ParaMiktari;

        //Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmud\Desktop\YZMYapimi\YZMYapimiProjesi\YZMYapimiProjesi\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();


        private void btnYukle_Click(object sender, EventArgs e)
        {
            ParaMiktari = Int32.Parse(TbPara.Text);
            if (ParaMiktari > 1000)
            {
                MessageBox.Show("Günlük limit üstünde bir yükleme yapamazsınız!", "Yükleme Başarsız" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con.Open();
                string query = "INSERT INTO [AliciTable](WalletBalance) VALUES('" + ParaMiktari + "')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                Alici.AliciForm frm = new Alici.AliciForm();
                
                MessageBox.Show("Paranız Yüklendi!", "Yükleme Başarlı", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                this.Hide();

            }
        }

        readonly YaziSartlari sart = new YaziSartlari();
        private void TbPara_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.AllowNumberOnly(e, TbPara, errProvParaEkle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
