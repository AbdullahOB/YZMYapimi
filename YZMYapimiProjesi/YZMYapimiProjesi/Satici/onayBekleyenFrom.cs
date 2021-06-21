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
    public partial class onayBekleyenFrom : Form
    {
        private int _id;
        private string _saticiAdi;
        public int _walletBalance;
        private readonly DbEntity _db;
        public onayBekleyenFrom(int id, string saticiAdi, int walletBalance)
        {
            InitializeComponent();
            _db = new DbEntity();
            _id = id;
            _saticiAdi = saticiAdi;
            _walletBalance = walletBalance;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak Emin Misiniz ", "Uyarı", MessageBoxButtons.YesNo);
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

        private void onayBekleyenFrom_Load(object sender, EventArgs e)
        {
            var onayBekleyen = _db.SaticiRequest.ToList();
            foreach (var l in onayBekleyen)
            {
                if (l.KullaniciId == _id)
                {
                    if (l.StatueId == 2)
                    {
                        if (l.urnMiktari > 0)
                        {
                            ListViewItem addStok = new ListViewItem(l.Id.ToString());
                            addStok.BackColor = Color.Red;
                            addStok.ForeColor = Color.White;
                            addStok.SubItems.Add(l.urnAdi);
                            addStok.SubItems.Add(l.urnMiktari.ToString());
                            addStok.SubItems.Add(l.urnFiyati.ToString());

                            onayBekleyenLst.Items.Add(addStok);

                        }

                    }

                    else if (l.StatueId == 3)
                    {
                        if (l.urnMiktari > 0)
                        {
                            ListViewItem addStok = new ListViewItem(l.Id.ToString());
                            addStok.SubItems.Add(l.urnAdi);
                            addStok.SubItems.Add(l.urnMiktari.ToString());
                            addStok.SubItems.Add(l.urnFiyati.ToString());
                            onayBekleyenLst.Items.Add(addStok);
                        }
                            
                    }
                }


            }
        }

        private void urnSilBtn_Click(object sender, EventArgs e)
        {


            if (onayBekleyenLst.Items.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("Urun Silmekten Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int reqIds = Convert.ToInt32(onayBekleyenLst.SelectedItems[0].Text);
                        var SaticiReqId = _db.SaticiRequest.Find(reqIds);
                        _db.SaticiRequest.Remove(SaticiReqId);
                        _db.SaveChanges();
                        RefreshOnayLists();
                    }

                    catch
                    {
                        MessageBox.Show("Bir Urun Seciniz");
                    }

                }
            }
        }

        private void onayBekleyenLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int reqIds = Convert.ToInt32(onayBekleyenLst.SelectedItems[0].Text);
            var reqDB = _db.SaticiRequest.Find(reqIds);

            if (reqDB.StatueId == 2)
            {
                DuzetlmeFormu duzetlmeFormu = new DuzetlmeFormu(reqIds, _saticiAdi, _walletBalance);
                duzetlmeFormu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Sadece Rededilmiş Ürünleri Düzeltebilirsiniz..");
            }

        }

        public void RefreshOnayLists()
        {
            onayBekleyenLst.Items.Clear();
            var onayBekleyen = _db.SaticiRequest.ToList();

            foreach (var l in onayBekleyen)
            {
                if (l.KullaniciId == _id)
                {
                    if (l.StatueId == 2)
                    {

                        ListViewItem addStok = new ListViewItem(l.Id.ToString());
                        addStok.BackColor = Color.Red;
                        addStok.ForeColor = Color.White;
                        addStok.SubItems.Add(l.urnAdi);
                        addStok.SubItems.Add(l.urnMiktari.ToString());
                        addStok.SubItems.Add(l.urnFiyati.ToString());

                        onayBekleyenLst.Items.Add(addStok);


                    }

                    else if (l.StatueId == 3)
                    {
                        ListViewItem addStok = new ListViewItem(l.Id.ToString());
                        addStok.SubItems.Add(l.urnAdi);
                        addStok.SubItems.Add(l.urnMiktari.ToString());
                        addStok.SubItems.Add(l.urnFiyati.ToString());
                        onayBekleyenLst.Items.Add(addStok);
                    }
                }


            }



        }
    }
}
