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
    public partial class stokListesi : Form
    {
        private int _id;
        private string _saticiAdi;
        public int _walletBalance;
        private readonly DbEntity _db;
        public stokListesi(int id, string saticiAdi, int walletBalance)
        {
            InitializeComponent();
            _db = new DbEntity();
            _id = id;
            _saticiAdi = saticiAdi;
            _walletBalance = walletBalance;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
          
        }

        private void BackBtnPic_Click(object sender, EventArgs e)
        {
           
                saticiGiris saticiG = new saticiGiris(_id, _saticiAdi, _walletBalance);
                saticiG.Show();
                Hide();

           
        }

        private void stokListesi_Load(object sender, EventArgs e)
        {
            //Stokta
            var stoktaUrn = _db.SaticiVarliklari.ToList();
            foreach (var l in stoktaUrn)
            {

                if (l.KullaniciId == _id)
                {
                    ListViewItem addStok = new ListViewItem(l.Id.ToString());
                    addStok.SubItems.Add(l.urnAdi.ToString());
                    addStok.SubItems.Add(l.urnMiktari.ToString());
                    addStok.SubItems.Add(l.urnFiyat.ToString());
                    stoktaLst.Items.Add(addStok);
                }

            }
        }

        private void urnSilBtn_Click(object sender, EventArgs e)
        {

            
            if (stoktaLst.Items.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("Urun Silmekten Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int VarlikId = Convert.ToInt32(stoktaLst.SelectedItems[0].Text);
                        var Stok = _db.SaticiVarliklari.Find(VarlikId);
                        _db.SaticiVarliklari.Remove(Stok);
                        _db.SaveChanges();
                        RefreshStokListesi();
                    }

                    catch
                    {
                        MessageBox.Show("Bir Urun Seciniz");
                    }

                }
               

            }
        }

        public void RefreshStokListesi()
        {
            //Stokta
            stoktaLst.Items.Clear();
            var stoktaUrn = _db.SaticiVarliklari.ToList();
            foreach (var l in stoktaUrn)
            {
                if (l.KullaniciId == _id)
                {
                    ListViewItem addStok = new ListViewItem(l.Id.ToString());
                    addStok.SubItems.Add(l.urnAdi.ToString());
                    addStok.SubItems.Add(l.urnMiktari.ToString());
                    addStok.SubItems.Add(l.urnFiyat.ToString());
                    stoktaLst.Items.Add(addStok);
                }

            }
        }
    }
}
