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
using YZMYapimiProjesi.DB;

namespace YZMYapimiProjesi.Alici
{
    public partial class ParaEkleForm : Form
    {
        private readonly DBEntity1 _db;
        private int ParaMiktari;
        public ParaEkleForm()
        {
            InitializeComponent();
            _db = new DBEntity1();
        }
        
        private void btnYukle_Click(object sender, EventArgs e)
        {
            ParaMiktari = Int32.Parse(TbPara.Text);
            if (ParaMiktari > 1000)
            {
                MessageBox.Show("Günlük limit üstünde bir yükleme yapamazsınız!", "Yükleme Başarsız" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

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

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
