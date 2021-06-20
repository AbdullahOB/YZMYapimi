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
   
    public partial class saticiGiris : Form
    {
        private int _id;
        private string _saticiAdi;
        public int _walletBalance;
        private readonly DbEntity _db;

        public saticiGiris(int id, string saticiAdi, int walletBalance)
        {
            InitializeComponent();
            _db = new DbEntity();
            _id = id;
            _saticiAdi = saticiAdi;
            _walletBalance = walletBalance;

        }

        private void saticiGiris_Load(object sender, EventArgs e)
        {
           
            Paralbl.Text = _walletBalance.ToString();
            isimlabel.Text = _saticiAdi;
        }

        private void RefreshBtn(object sender, EventArgs e)
        {
            var user = _db.KullaniciTable.Find(_id);
            Paralbl.Text = user.WalletBalance.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak Emin Misiniz ", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

      

        private void BackBtnFun(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hesaptan Çıkmak Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login.LoginForm log = new Login.LoginForm();
                log.Show();
                Hide();

            }
        }

        private void stokListesiBtn_Click(object sender, EventArgs e)
        {
            stokListesi stok = new stokListesi(_id, _saticiAdi, _walletBalance);
            stok.Show();
            Hide();
        }

        private void onayBekleyenBtn_Click(object sender, EventArgs e)
        {
            onayBekleyenFrom onayFrom = new onayBekleyenFrom(_id , _saticiAdi, _walletBalance);
            onayFrom.Show();
            Hide();
        }

        private void UrnEkleBtn_Click(object sender, EventArgs e)
        {
            UrunEkForm urnEk = new UrunEkForm(_id, _saticiAdi, _walletBalance);
            urnEk.Show();
            Hide();
        }
    }
}
