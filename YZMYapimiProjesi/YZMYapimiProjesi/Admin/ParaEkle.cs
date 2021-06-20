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
using System.Xml;

namespace YZMYapimiProjesi.Admin
{
    public partial class ParaEkle : Form
    {
        private readonly DbEntity _db;
        private int _reqId;
        public ParaEkle(int reqId)
        {
            InitializeComponent();
            _db = new DbEntity();
            _reqId = reqId;
        }
        private void ParaEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void ParaEkle_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void ParaEkle_Load(object sender, EventArgs e)
        {
            var req = _db.RequestTable.Find(_reqId);
            var adi = req.KullaniciTable.Ad;
            var paraBirim = req.ParaBirimi;
            var paraMik = req.ParaMiktari;
            
            paraMiklbl.Text = paraMik.ToString();
            lbl_paraBirimi.Text = paraBirim;
            aliciAdlbl.Text = adi;
        }
        private void urnBilgileriReddet_Click(object sender, EventArgs e)
        {
            var req = _db.RequestTable.Find(_reqId);
            req.statueId = 2;
            _db.SaveChanges();
            MessageBox.Show("Red Islemi Başarıyla Gerçekleşti...", "Red  işelmi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParaEklemeLstFromAdmin ParaAdmin = new ParaEklemeLstFromAdmin();
            ParaAdmin.Show();
            Hide();
        }
        private void BackBtnPic_Click(object sender, EventArgs e)
        {
            ParaEklemeLstFromAdmin ParaAdmin = new ParaEklemeLstFromAdmin();
            ParaAdmin.Show();
            Hide();
        }
        private void ParaEklemeTalepiBtn(object sender, EventArgs e)
        {
            //doviz kuru fiyati cekmek
            String bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);


            
            var req = _db.RequestTable.Find(_reqId);
            var user = _db.KullaniciTable.Find(req.KullaniciId);

            if (req.ParaBirimi == "TL")
            {
                 req.statueId = 1;
                 _db.Entry(req).State = System.Data.Entity.EntityState.Modified;
                 user.WalletBalance += req.ParaMiktari;                
            }
            else
            {
                string alisFiyat = "";
                if (req.ParaBirimi == "USD")
                {
                    string dolarAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                    float usd = float.Parse(dolarAlis);
                    req.statueId = 1;
                    _db.Entry(req).State = System.Data.Entity.EntityState.Modified;
                    user.WalletBalance = user.WalletBalance + (req.ParaMiktari * usd);
                    alisFiyat = dolarAlis;
                }
                else if (req.ParaBirimi == "EUR")
                {
                    string euroAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                    float eur = float.Parse(euroAlis);
                    req.statueId = 1;
                    _db.Entry(req).State = System.Data.Entity.EntityState.Modified;
                    user.WalletBalance = user.WalletBalance + (req.ParaMiktari * eur);
                    alisFiyat = euroAlis;
                }
                else if (req.ParaBirimi == "GBP")
                {
                    string sterlinAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
                    float gbp = float.Parse(sterlinAlis);
                    req.statueId = 1;
                    _db.Entry(req).State = System.Data.Entity.EntityState.Modified;
                    user.WalletBalance =  user.WalletBalance + (req.ParaMiktari * gbp);
                    alisFiyat = sterlinAlis;
                }
                string alisBilgileri = DateTime.Now.ToString() + " Tarihinde "+ req.ParaMiktari +" "+ req.ParaBirimi+ " { " + alisFiyat + " TL  } karşılığında yükleme yapıldı ";
                req.DovizBilgileri = alisBilgileri;
            }
            _db.SaveChanges();
            MessageBox.Show("Para Ekleme Islemi Başarıyla Gerçekleşti ...", "Para Ekleme işelmi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParaEklemeLstFromAdmin ParaAdmin = new ParaEklemeLstFromAdmin();
            ParaAdmin.Show();
            Hide();
        }
    }
}
