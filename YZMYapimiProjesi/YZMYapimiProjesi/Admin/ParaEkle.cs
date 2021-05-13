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
            

            var req = _db.RequestTables.Find(_reqId);
            var adi = req.KullaniciTable.Ad;
            var paraMik = req.ParaMiktari;
            
            paraMiklbl.Text = paraMik.ToString();
            aliciAdlbl.Text = adi.ToString();

        }
        
     
        private void urnBilgileriReddet_Click(object sender, EventArgs e)
        {
            var req = _db.RequestTables.Find(_reqId);
            req.statueId = 2;
            _db.SaveChanges();
            MessageBox.Show("Red Islemi Başarıyla Gerçekleşti ...", "Red  işelmi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                          var req = _db.RequestTables.Find(_reqId);
                        var user = _db.KullaniciTables.Find(req.KullaniciId);
                        req.statueId = 1;
                        _db.Entry(req).State = System.Data.Entity.EntityState.Modified;
                        user.WalletBalance += req.ParaMiktari;
                        _db.SaveChanges();
            MessageBox.Show("Para Ekleme Islemi Başarıyla Gerçekleşti ...", "Para Ekleme işelmi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParaEklemeLstFromAdmin ParaAdmin = new ParaEklemeLstFromAdmin();
            ParaAdmin.Show();
            Hide();
        }
    }
}
