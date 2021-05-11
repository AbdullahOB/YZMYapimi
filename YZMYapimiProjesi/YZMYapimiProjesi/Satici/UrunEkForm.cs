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
        public int _id;
        
        public UrunEkForm(int id , string saticiAdi)
        {
            InitializeComponent();

            _db = new DbEntity();
            _saticiAdi = saticiAdi;
            _id = id;
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaticiForm obj1 = new SaticiForm(_id ,_saticiAdi);
            obj1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void UrunEkForm_Load(object sender, EventArgs e)
        {
        
        }

        public void button1_Click(object sender, EventArgs e)
        {

            
            var satReq = _db.SaticiRequest.Create();
            var users = _db.KullaniciTables.Find(_id);
            satReq.KullaniciId = _id;
            satReq.urnAdi = comboBox1.Text;
            satReq.urnMiktari = Convert.ToInt32(textBox1.Text);
            satReq.urnFiyati = Convert.ToInt32(textBox2.Text);
            satReq.StatueId = 3;
            satReq.Message = users.KullaniciAdi + " Urun Ekleme Telpi Gonderdi ";
            _db.SaticiRequest.Add(satReq);
            _db.SaveChanges();


        }
        YaziSartlari yaz = new YaziSartlari();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            yaz.AllowNumberOnly(e, textBox1, err);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            yaz.AllowNumberOnly(e, textBox2, err);
        }
    }
}
