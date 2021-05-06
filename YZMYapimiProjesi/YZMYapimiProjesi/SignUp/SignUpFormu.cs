using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using YZMYapimiProjesi.Login;

namespace YZMYapimiProjesi.SignUp
{
    public partial class SignUpFormu : Form
    {
        public SignUpFormu()
        {
            InitializeComponent();
        }
        

        //Build Data base connection

        private void btnSgnUp_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" && txtSoyad.Text == "" && txtKullaniciAdi.Text == "" && txtTC.Text == "" && txtTelNo.Text == "" && txtEposta.Text == "" && txtSifre1.Text == "" && txtSifre2.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.", "Kayıt Olunmadı" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSifre1.Text == txtSifre2.Text)
            {
                //TO DO: Open database and save the values

                MessageBox.Show("Kayıdınız Başarıyla Tamamlanmıştır!", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("hello");
            LoginForm frm = new LoginForm();
            frm.Show();
        }
    }
}
