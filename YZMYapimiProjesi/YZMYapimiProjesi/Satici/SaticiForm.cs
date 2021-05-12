using LinqToDB;
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
    public partial class SaticiForm : Form
    {
        private int _id;
        private string _saticiAdi;
        public int _walletBalance;
        
        private readonly DbEntity _db;

        public SaticiForm( int id , string saticiAdi, int walletBalance)
        {
            InitializeComponent();
            _db = new DbEntity();
            _id = id;
            _saticiAdi = saticiAdi;
          
            _walletBalance = walletBalance;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Login.LoginForm obj = new Login.LoginForm();
            obj.Show();
        }

        private void UrunEkbtn_Click(object sender, EventArgs e)
        {
           

            this.Hide();
            UrunEkForm obj = new UrunEkForm(_id , _saticiAdi ,_walletBalance);
            obj.Show();
            
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SaticiForm_Load(object sender, EventArgs e)
        {
            lblPara.Text = _walletBalance.ToString();
            isimlabel.Text = _saticiAdi;

            
            //TODO: This Solution Will Be Edited;

            //Onay Bekleyen
            var onayBekleyen = _db.SaticiRequest.ToList();
            

            foreach (var l in onayBekleyen)
            {
                if(l.KullaniciId == _id)
                {
                    if (l.StatueId == 2)
                    {
                        ListViewItem addStok = new ListViewItem(l.Id.ToString());
                        addStok.BackColor = Color.Red;
                        addStok.ForeColor = Color.White;
                        addStok.SubItems.Add(l.urnAdi);
                        addStok.SubItems.Add(l.urnMiktari.ToString());
                        addStok.SubItems.Add(l.urnFiyati.ToString());

                        onayBekleyenUrnLst.Items.Add(addStok);


                    }

                    else if (l.StatueId == 3)
                    {
                        ListViewItem addStok = new ListViewItem(l.Id.ToString());
                        addStok.SubItems.Add(l.urnAdi);
                        addStok.SubItems.Add(l.urnMiktari.ToString());
                        addStok.SubItems.Add(l.urnFiyati.ToString());
                        onayBekleyenUrnLst.Items.Add(addStok);
                    }
                }
              

            }

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

        private void onayBekleyenUrnLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int reqIds = Convert.ToInt32(onayBekleyenUrnLst.SelectedItems[0].Text);
            var reqDB = _db.SaticiRequest.Find(reqIds);

            if(reqDB.StatueId == 2)
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
            onayBekleyenUrnLst.Items.Clear();
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

                                        onayBekleyenUrnLst.Items.Add(addStok);


                                    }

                                    else if (l.StatueId == 3)
                                    {
                                        ListViewItem addStok = new ListViewItem(l.Id.ToString());
                                        addStok.SubItems.Add(l.urnAdi);
                                        addStok.SubItems.Add(l.urnMiktari.ToString());
                                        addStok.SubItems.Add(l.urnFiyati.ToString());
                                        onayBekleyenUrnLst.Items.Add(addStok);
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
        private void UrunSilbtn_Click(object sender, EventArgs e)
        {
                if (onayBekleyenUrnLst.Items.Count > 0)
                {
                    try
                    {
                        int reqIds = Convert.ToInt32(onayBekleyenUrnLst.SelectedItems[0].Text);
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

        private void StoktaUrunSilbtn_Click(object sender, EventArgs e)
        {
            if (stoktaLst.Items.Count > 0)
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

        private void PbRefresh_Click(object sender, EventArgs e)
        {

            var user = _db.KullaniciTables.Find(_id);
            lblPara.Text = user.WalletBalance.ToString();
        }
    }
}
