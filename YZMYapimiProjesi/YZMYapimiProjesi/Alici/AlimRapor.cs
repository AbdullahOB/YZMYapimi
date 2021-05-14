using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YZMYapimiProjesi.DB;
namespace YZMYapimiProjesi.Alici
{
    public partial class AlimRapor : Form
    {
        private readonly DbEntity _db;
        private int _aliciID;
        private int _islemSayi;
        

        private void AlimRapor_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(TbUrunBilgi.Text);

            int t = 0;
            var alimSatimIslem = _db.AlimSatimIslemler.OrderByDescending(q => q.islemZamani);
            foreach (var l in alimSatimIslem)
            {
                if (l.AliciId == _aliciID)
                {
                    sb.Append("\nAlınan Ürün: " + l.urnAdi + ", Ürün Mıktarı: " + l.Miktar + " (KG) " + ", Aliş Fiyatı: " + l.Fiyat + " (TL) \n");
                    t++;
                }
                if (t == _islemSayi)
                {
                    break;
                }
            }

            TbUrunBilgi.Text = sb.ToString();

            
        }

        public AlimRapor(int aliciID , int islemSayi)
        {
            InitializeComponent();
            _aliciID = aliciID;
            _islemSayi = islemSayi;
            _db = new DbEntity();
        }


        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var time = DateTime.Now;
            var userAdi = _db.AlimSatimIslemler.FirstOrDefault(q => q.AliciId == _aliciID);
            e.Graphics.DrawString("Dekont", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10,10));
            e.Graphics.DrawString(userAdi.AliciAdi, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 10));
            e.Graphics.DrawString(time.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(700, 10));
            e.Graphics.DrawString("_____________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 60));


            var alimSatimIslem = _db.AlimSatimIslemler.OrderByDescending(q =>q.islemZamani);
            var fnt = new Font("Arial", 6, FontStyle.Bold);
            int x = 100, y = 100;
            int dy = (int)fnt.GetHeight(e.Graphics) * 1;
            int t =0;
                foreach (var l in alimSatimIslem)
                {
                    if (l.AliciId == _aliciID)
                    {
                        e.Graphics.DrawString("Alınan Ürün: " + l.urnAdi + ", Ürün Mıktarı: " + l.Miktar + " (KG) " + ", Aliş Fiyatı: " + l.Fiyat + " (TL) " + ", Alıcı Adi: " + l.AliciAdi + ", Alıcı ID: " + l.AliciId + ", Satıcı Adı: " + l.SaticiAdi + ", Satıcı ID: " + l.SaticiId + ", İşlem Zamanı : " + l.islemZamani.ToString(), fnt, Brushes.Black, new Point(x, y)); y += dy;
                        e.Graphics.DrawString("__________________________________________________________________________________________________________________________", fnt, Brushes.Black, new Point(x, y)); y += dy;
                    t++;
                    }
                    if (t == _islemSayi)
                    {
                        break;
                    }
                }
            
            
           
        }
        private void PbSave_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;


            DialogResult res = printDialog.ShowDialog();
            if (res == DialogResult.OK)
            {

                printDocument1.Print();

            }
            this.Hide();
        }
    }
}
