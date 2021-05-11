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
    public partial class DuzetlmeFormu : Form
    {
        private readonly DbEntity _db;
        private int _id;
        private string _saticiAdi;
        YaziSartlari yaz = new YaziSartlari();
        public DuzetlmeFormu(int reqId , string saticiAdi)
        {
            InitializeComponent();
          
            _id = reqId;
            _saticiAdi = saticiAdi;
            _db = new DbEntity();
        }

        private void DuzetlmeFormu_Load(object sender, EventArgs e)
        {
            

            var reqRed = _db.SaticiRequest.Find(_id);
            var redMsg = reqRed.MessageFromAdmin;
            redSebebiTxt.Text = redMsg;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaticiForm saticiForm = new SaticiForm(_id , _saticiAdi);
            saticiForm.Show();
            Hide();
        }

        private void TalepGonderBtn(object sender, EventArgs e)
        {
          
           
            var satReq = _db.SaticiRequest.Find(_id);
            var users = _db.KullaniciTables.Find(satReq.KullaniciId);

            satReq.urnAdi = urnTipiCmb.Text;
            satReq.urnMiktari = Convert.ToInt32(urnMiktariTxt.Text);
            satReq.urnFiyati = Convert.ToInt32(urnFiyatiTxt.Text);
            satReq.StatueId = 3;

            satReq.Message = users.KullaniciAdi + " Ürün Ekleme Talepi Düzetildi... ";
            
            _db.SaveChanges();
        }

      
        private void urnFiyatiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            yaz.AllowNumberOnly(e, urnFiyatiTxt, err);
        }

        private void urnMiktariTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            yaz.AllowNumberOnly(e, urnMiktariTxt, err);
        }
    }
}
