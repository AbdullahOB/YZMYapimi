using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YZMYapimiProjesi.Login;
using System.Data.SqlClient;
using YZMYapimiProjesi.DB;

namespace YZMYapimiProjesi.SignUp
{
    public partial class SignUpFormu : Form
    {
        private readonly DbEntity _db;
        
        public SignUpFormu()
        {
            InitializeComponent();
            _db = new DbEntity();
        }

        string kullaniciTipi;

        private void RBsatici_CheckedChanged(object sender, EventArgs e)
        {
            kullaniciTipi = "Satici";
        }

        private void RBalici_CheckedChanged(object sender, EventArgs e)
        {
            kullaniciTipi = "Alici";
        }
        private void btnSgnUp_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" && txtSoyad.Text == "" && txtKullaniciAdi.Text == "" && txtTC.Text == "" && txtTelNo.Text == "" && txtEposta.Text == "" && txtSifre1.Text == "" && txtSifre2.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.", "Kayıt Olunmadı" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSifre1.Text == txtSifre2.Text)
            {

                var user = _db.KullaniciTables.Create();
                user.KullaniciAdi = txtKullaniciAdi.Text;
                user.Sifre = txtSifre1.Text;
                user.Ad = txtAd.Text;
                user.Soyad = txtSoyad.Text;
                user.Email = txtEposta.Text;
                user.TCKimlikNo = long.Parse(txtTC.Text);
                user.Tel = long.Parse(txtTelNo.Text);
                user.Adres = txtAdres.Text;
                user.KullaniciTipi = kullaniciTipi;
                user.WalletBalance = 0;
                _db.KullaniciTables.Add(user);
                var role = _db.KullaniciRoles.Create();
                role.KullaniciId = user.Id;
                if (kullaniciTipi == "Alici")
                {
                    role.RoleId = 3;
                }
                else
                {
                    role.RoleId = 2;
                }
                _db.KullaniciRoles.Add(role);
                _db.SaveChanges();

                MessageBox.Show("Kayıdınız Başarıyla Tamamlanmıştır!", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm frm = new LoginForm(txtKullaniciAdi.Text);
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("Şifreler Eşleşmiyor, Lüfen Tekrar Deneyiniz.", "Kayıt Olunmadı", MessageBoxButtons.OK , MessageBoxIcon.Error);
                txtSifre1.Text = "";
                txtSifre2.Text = "";
                txtSifre1.Focus();
            }
        }

        private void PBimageGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        readonly YaziSartlari sart = new YaziSartlari();
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.AllowNumberOnly(e, txtTC, errorProvider1);
        }

        private void txtTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.AllowNumberOnly(e, txtTelNo, errorProvider2);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.AllowTextOnly(e, txtAd, errorProvider3);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.AllowTextOnly(e, txtSoyad, errorProvider3);
        }
        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.denaySpace(e, txtKullaniciAdi, errProvKullaniciAdi);
        }

    }
}
