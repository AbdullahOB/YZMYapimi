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
    public partial class UrunEkForm : Form
    {
        private readonly DbEntity _db;
        private string _saticiAdi;
        private int _walletBalance;
        public int _id;
        
        public UrunEkForm(int id , string saticiAdi ,int walletBalance)
        {
            InitializeComponent();

            _db = new DbEntity();
            _walletBalance = walletBalance;
            _saticiAdi = saticiAdi;
            _id = id;
          
        }


        YaziSartlari yaz = new YaziSartlari();
        private void urnMiktarTxtBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            yaz.AllowNumberOnly(e, urnMiktarTxtBox, err);
        }

        private void urnFiyatTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            yaz.AllowNumberOnly(e, urnFiyatTxtBox, err);
        }


        private void Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak Emin Misiniz ", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BackBtnPic_Click_1(object sender, EventArgs e)
        {
            saticiGiris saticiG = new saticiGiris(_id, _saticiAdi, _walletBalance);
            saticiG.Show();
            Hide();

        }

        private void talepGonderBtnFun(object sender, EventArgs e)
        {
            if(urnSecCmBox.Text != "")
            {
                var satReq = _db.SaticiRequest.Create();
                var users = _db.KullaniciTables.Find(_id);
                satReq.KullaniciId = _id;
                satReq.urnAdi = urnSecCmBox.Text;
                satReq.urnMiktari = Convert.ToInt32(urnMiktarTxtBox.Text);
                satReq.urnFiyati = Convert.ToInt32(urnFiyatTxtBox.Text);
                satReq.StatueId = 3;
                satReq.Message = users.KullaniciAdi + " Urun Ekleme Telpi Gonderdi ";
                _db.SaticiRequest.Add(satReq);
                _db.SaveChanges();

                MessageBox.Show("Talepinizi Başarıyla Göndermiştir ...", "Talep Gönderme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfet Ürün Seçiniz ...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
