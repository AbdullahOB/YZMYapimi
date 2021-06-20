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
    public partial class UrnBilgileri : Form
    {
        private readonly DbEntity _db;
        private int _id;
        public UrnBilgileri(int id)
        {
            InitializeComponent();
            _db = new DbEntity();
            _id = id;
           
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            AdminAraYuzu admin = new AdminAraYuzu();
            admin.Visible = true;
            Close();
        }

        private void urnBilgileriOnayla_Click(object sender, EventArgs e)
        {
            var req = _db.SaticiRequest.Find(_id);
            req.StatueId = 1;
            //_db.Entry(req).State = System.Data.Entity.EntityState.Modified;
            var saticiVar = _db.SaticiVarliklari.Create();
            saticiVar.KullaniciId = req.KullaniciId;
            saticiVar.urnAdi = req.urnAdi;
            saticiVar.urnFiyat = req.urnFiyati;
            saticiVar.urnMiktari = req.urnMiktari;
            _db.SaticiVarliklari.Add(saticiVar);
            _db.SaveChanges();
             MessageBox.Show("Onay Islemi Başarıyla Gerçekleşti ...", "Onay işelmi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            onayBekleyenLstFormAdmin onayLst = new onayBekleyenLstFormAdmin();
            onayLst.Show();
            Hide();
        }

        private void UrnBilgileri_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        Point lastPoint;

        private void UrnBilgileri_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void UrnBilgileri_Load(object sender, EventArgs e)
        {
            
            var req = _db.SaticiRequest.Find(_id);
            var user = _db.KullaniciTable.Find(req.KullaniciId);
            var adi = user.KullaniciAdi;
            var urnTipi = req.urnAdi;
            var urnMiktari = req.urnMiktari;
            var urnFiyat = req.urnFiyati;

          
            urnBilgilerTipi.Text = urnTipi;
            urnMiktariLbl.Text = urnMiktari.ToString();
            urnBirimFiyatiLbl.Text = urnFiyat.ToString();
            SaticiAdiLbl.Text = adi;
        }

        private void urnBilgileriReddet_Click(object sender, EventArgs e)
        {
            if(redSebebiTxt.Text == "")
            {
                MessageBox.Show("Red Sebebi Yaziniz ");
            }
            else
            {
                var req = _db.SaticiRequest.Find(_id);
                req.StatueId = 2;
                req.MessageFromAdmin = redSebebiTxt.Text;
                var saticiVar = _db.SaticiVarliklari.Create();
                saticiVar.KullaniciId = req.KullaniciId;
                saticiVar.urnAdi = req.urnAdi;
                saticiVar.urnFiyat = req.urnFiyati;
                saticiVar.urnMiktari = req.urnMiktari;
                saticiVar.Message = req.MessageFromAdmin;
                _db.SaticiVarliklari.Add(saticiVar);
                _db.SaveChanges();
                MessageBox.Show("Red Islemi Başarıyla Gerçekleşti ...", "Red işelmi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                onayBekleyenLstFormAdmin onayLst = new onayBekleyenLstFormAdmin();
                onayLst.Show();
                Hide();
            }
           
        }

        private void BackBtnPic_Click(object sender, EventArgs e)
        {
            onayBekleyenLstFormAdmin onayLst = new onayBekleyenLstFormAdmin();
            onayLst.Show();
            Hide();
        }
    }
}
