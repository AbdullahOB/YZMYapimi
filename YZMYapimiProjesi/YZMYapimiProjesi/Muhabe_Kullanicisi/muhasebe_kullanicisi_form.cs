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

namespace YZMYapimiProjesi.Muhabe_Kullanicisi
{
    public partial class muhasebe_kullanicisi_form : Form
    {
        private readonly DbEntity _db;
        public muhasebe_kullanicisi_form()
        {
            InitializeComponent();
            _db = new DbEntity();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak Emin Misiniz ", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hesaptan Çıkmak Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login.LoginForm log = new Login.LoginForm();
                log.Show();
                Hide();
            }
        }

        private void refreshBtnNew_Click(object sender, EventArgs e)
        {
            var user = _db.KullaniciTable.FirstOrDefault(q => q.Id == 25);
            if(user != null)
            {
                float balance = (float)(user.WalletBalance);
                Paralbl.Text = balance.ToString("0.00");
            }
            else
            {
                MessageBox.Show("There's Something wrong here!");
            }
           
        }

        private void muhasebe_kullanicisi_form_Load(object sender, EventArgs e)
        {
            var user = _db.KullaniciTable.FirstOrDefault(q => q.Id == 25);
            if (user != null)
            {
                float balance =(float)( user.WalletBalance);
                Paralbl.Text = balance.ToString("0.00");
            }
        }
    }
}
