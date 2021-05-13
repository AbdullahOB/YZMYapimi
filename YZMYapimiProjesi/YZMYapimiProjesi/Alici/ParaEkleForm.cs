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
        private readonly DbEntity _db;
        private int ParaMiktari = 0;
        public int _id;
        public string _ad;
        public ParaEkleForm(int UserId , string ad)
        {
            InitializeComponent();
            _db = new DbEntity();
            _ad = ad;
            _id = UserId;

        }
        private void btnYukle_Click(object sender, EventArgs e)
        {

            if (TbPara.Text != "")
            {
                ParaMiktari = Int32.Parse(TbPara.Text);
            }

            if (CbOnaylaPara.CheckState == CheckState.Checked)
            {
                
                if (ParaMiktari< 1000 && ParaMiktari>0)
                {

                    var req = _db.RequestTables.Create();
                    req.KullaniciId = _id;
                    req.statueId = 3;
                    req.MsgSubject = _ad + " isimli kullanici " + ParaMiktari + " TL Para Talepi Gonderdi";
                    req.ParaMiktari = ParaMiktari;
                    _db.RequestTables.Add(req);


                    MessageBox.Show("Talebiniz Alinmistir", "Yükleme Beklemede", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    _db.SaveChanges();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Günlük limit dışında bir yükleme yapamazsınız!", "Yükleme Başarsız" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Onaylıyorum kısmını işaretleyiniz!", "Yükleme Başarsız", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
