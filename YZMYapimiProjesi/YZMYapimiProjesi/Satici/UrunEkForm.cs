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
        public int _id;
        
        public UrunEkForm(int id )
        {
            InitializeComponent();

            _db = new DbEntity();
            _id = id;
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaticiForm obj1 = new SaticiForm(_id);
            obj1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void UrunEkForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Buğday");
            comboBox1.Items.Add("Yulaf");
            comboBox1.Items.Add("Pamuk");
        }

        public void button1_Click(object sender, EventArgs e)
        {

            var users = _db.KullaniciTables.Find(_id);
            var satReq = _db.SaticiRequest.Create();
            satReq.KullaniciId = _id;
            satReq.urnAdi = comboBox1.Text;
            satReq.urnMiktari = Convert.ToInt32(textBox1.Text);
            satReq.urnFiyati = Convert.ToInt32(textBox2.Text);
            satReq.StatueId = 3;
            satReq.Message = users.KullaniciAdi + " Urun Ekleme Telpi Gonderdi ";
            _db.SaticiRequest.Add(satReq);
            _db.SaveChanges();


        }
    }
}
