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

        private void ExitBtnFun(object sender, EventArgs e)
        {
            AdminAraYuzu admin = new AdminAraYuzu();
            admin.Visible = true;
            Close();
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
            var adi = req.MsgSubject;
            var paraMik = req.ParaMiktari;
            
            paraMiklbl.Text = paraMik.ToString();
            aliciAdlbl.Text = adi.ToString();

        }
        
        private void urnBilgileriOnayla_Click(object sender, EventArgs e)
        {
            
            
            var req = _db.RequestTables.Find(_reqId);
            var user = _db.KullaniciTables.Find(req.KullaniciId);
            req.statueId = 1;
            _db.Entry(req).State = System.Data.Entity.EntityState.Modified;
            user.WalletBalance += req.ParaMiktari;
            _db.SaveChanges();


        }

        private void urnBilgileriReddet_Click(object sender, EventArgs e)
        {
            var req = _db.RequestTables.Find(_reqId);
            req.statueId = 2;
            _db.SaveChanges();
        } 
    }
}
