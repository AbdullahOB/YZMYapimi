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
        private int _walletBalance;
        
        public DuzetlmeFormu( int reqId , string saticiAdi , int walletBalance)
        {
            InitializeComponent();
          
            _id = reqId;
            _saticiAdi = saticiAdi;
            _walletBalance = walletBalance;
            _db = new DbEntity();
        }

        private void DuzetlmeFormu_Load(object sender, EventArgs e)
        {
           
        }

        private void TalepGonderBtn(object sender, EventArgs e)
        {
            var satReq = _db.SaticiRequest.Find(_id);
            var users = _db.KullaniciTable.Find(satReq.KullaniciId);
            satReq.urnAdi = urnTipiCmb.Text;
            satReq.urnMiktari = Convert.ToInt32(urnMiktariTxt.Text);
            satReq.urnFiyati = Convert.ToInt32(urnFiyatiTxt.Text);
            satReq.StatueId = 3;
            satReq.Message = users.KullaniciAdi + " Ürün Ekleme Talepi Düzetildi... ";
            _db.SaveChanges();
            MessageBox.Show("Talepinizi Başarıyla Göndermiştir ...", "Talep Gönderme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        YaziSartlari yaz = new YaziSartlari();
        private void urnMiktariTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            yaz.AllowNumberOnly(e, urnMiktariTxt, err);
        }

        private void urnFiyatiTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            yaz.AllowNumberOnly(e, urnFiyatiTxt, err);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak Emin Misiniz ", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BackBtnPic_Click(object sender, EventArgs e)
        {
            var urunBekleyenDb = _db.SaticiRequest.Find(_id);
            var userId = urunBekleyenDb.KullaniciTable.Id;
            onayBekleyenFrom onayBekleyen = new onayBekleyenFrom(userId, _saticiAdi, _walletBalance);
            onayBekleyen.Show();
            Hide();
        }

        private void redSebebiTxt_Click(object sender, EventArgs e)
        {

            var reqRed = _db.SaticiRequest.Find(_id);
            var redMsg = reqRed.MessageFromAdmin;

            MessageBox.Show(redMsg, "Ekleme Red Sebebi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
