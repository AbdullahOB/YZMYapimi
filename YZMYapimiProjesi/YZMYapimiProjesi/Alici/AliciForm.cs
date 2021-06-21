using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using YZMYapimiProjesi.DB;
using YZMYapimiProjesi.Login;

namespace YZMYapimiProjesi.Alici
{
    public partial class AliciForm : Form
    {
        private readonly DbEntity _db;
        private YaziSartlari sart;
        public LoginForm _login;
        public string _ad;
        public int _walletBalance;
        public int _id, _id2;

        public AliciForm(LoginForm login, string Ad, int walletBalance, int id)
        {
            InitializeComponent();
            _db = new DbEntity();
            _login = login;
            _ad = Ad;
            _walletBalance = walletBalance;
            _id = id;
        }

        public AliciForm()
        {
            InitializeComponent();
        }

        private void AliciForm_Load(object sender, EventArgs e)
        {
            lblName.Text = _ad;
            Paralbl.Text = _walletBalance.ToString();
            var alici = _db.RequestTable.Where(q=> q.KullaniciId == _id && q.statueId == 3).ToList();
            foreach (var req in alici)
            {
                ListViewItem addReq = new ListViewItem(req.ParaBirimi);
                addReq.SubItems.Add(req.ParaMiktari.ToString());
                LV_BekleyenOdeme.Items.Add(addReq);
            }

            //Beklyen Islemler Load
            var bekleyenIslem = _db.BeklyenIslemlerTable.ToList();
            foreach (var l in bekleyenIslem)
            {

                if (l.AliciID == _id)
                {

                    ListViewItem addStok = new ListViewItem(l.Id.ToString());
                    addStok.SubItems.Add(l.UrunAdi);
                    addStok.SubItems.Add(l.UrunMiktari.ToString());
                    addStok.SubItems.Add(l.UrunFiyati.ToString());
                    LV_BeklyenIslemler.Items.Add(addStok);
                }

            }

            this.requestTableTableAdapter1.Fill(this.requestDataSet1.RequestTable);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;


            DialogResult res = printDialog.ShowDialog();
            if (res == DialogResult.OK)
            {

                printDocument1.Print();

            }
            this.Hide();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var time = DateTime.Now;
            var userAdi = _db.AlimSatimIslemler.FirstOrDefault(q => q.AliciId == _id);
            e.Graphics.DrawString("Alım Satım Raporu ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString(userAdi.AliciAdi, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 10));
            e.Graphics.DrawString(time.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(700, 10));
            e.Graphics.DrawString("_____________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 60));


            var alimSatimIslem = _db.AlimSatimIslemler.OrderByDescending(q => q.islemZamani);
            var fnt = new Font("Arial", 6, FontStyle.Bold);
            int x = 100, y = 100;
            int dy = (int)fnt.GetHeight(e.Graphics) * 1;
            int t = 0;
            foreach (var l in alimSatimIslem)
            {
                if (l.AliciId == _id)
                {


                    e.Graphics.DrawString("Alınan Ürün: " + l.urnAdi + ", Ürün Mıktarı: " + l.Miktar + " (KG) " + ", Aliş Fiyatı: " + l.Fiyat + " (TL) " + ", Alıcı Adi: " + l.AliciAdi + ", Alıcı ID: " + l.AliciId + ", Satıcı Adı: " + l.SaticiAdi + ", Satıcı ID: " + l.SaticiId + ", İşlem Zamanı : " + l.islemZamani.ToString(), fnt, Brushes.Black, new Point(x, y)); y += dy;
                    e.Graphics.DrawString("__________________________________________________________________________________________________________________________", fnt, Brushes.Black, new Point(x, y)); y += dy;
                    t++;
                }

            }

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
            DialogResult dialogResult = MessageBox.Show("Hesaptan Çıkmak Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login.LoginForm log = new Login.LoginForm();
                log.Show();
                Hide();
            }
        }
        private void RefreshLstView()
        {
            LV_BeklyenIslemler.Items.Clear();
            //Beklyen Islemler Load
            var bekleyenIslem = _db.BeklyenIslemlerTable.ToList();
            foreach (var l in bekleyenIslem)
            {

                if (l.AliciID == _id)
                {

                    ListViewItem addStok = new ListViewItem(l.Id.ToString());
                    addStok.SubItems.Add(l.UrunAdi);
                    addStok.SubItems.Add(l.UrunMiktari.ToString());
                    addStok.SubItems.Add(l.UrunFiyati.ToString());
                    LV_BeklyenIslemler.Items.Add(addStok);
                }

            }
        }
        private void refreshBtnNew_Click(object sender, EventArgs e)
        {
            var user = _db.KullaniciTable.Find(_id);
            float balance = (float)(user.WalletBalance);
            Paralbl.Text = balance.ToString("0.00");
            LV_BekleyenOdeme.Items.Clear();
            var alici = _db.RequestTable.Where(q => q.KullaniciId == _id && q.statueId == 3).ToList();
            foreach (var req in alici)
            {
                ListViewItem addReq = new ListViewItem(req.ParaBirimi);
                addReq.SubItems.Add(req.ParaMiktari.ToString());
                LV_BekleyenOdeme.Items.Add(addReq);
            }
        }

        

        private void TbMiktar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            sart = new YaziSartlari();
            sart.AllowNumberOnly(e, TbMiktar, errorProviderMiktar);
        }

        private void islemSilBtnClick(object sender, EventArgs e)
        {
            if (LV_BeklyenIslemler.Items.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("Işlemi Silmekten Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int reqIds = Convert.ToInt32(LV_BeklyenIslemler.SelectedItems[0].Text);
                        var islemBul = _db.BeklyenIslemlerTable.Find(reqIds);
                        _db.BeklyenIslemlerTable.Remove(islemBul);
                        _db.SaveChanges();
                        RefreshLstView();
                    }

                    catch
                    {
                        MessageBox.Show("Bir Urun Seciniz");
                    }

                }
            }
        }

        private void saveYukleme_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {//aaaaddaa
                            
                            workbook.Worksheets.Add(this.requestDataSet1.RequestTable.Where(q => q.KullaniciId == _id).CopyToDataTable(), "YüklemeListesi");
                            workbook.SaveAs(sfd.FileName);
                            string s = Path.GetFullPath(sfd.FileName);


                            FileInfo fileInfo = new FileInfo(s);
                            ExcelPackage package = new ExcelPackage(fileInfo);
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                            int rows = worksheet.Dimension.Rows;
                            worksheet.DeleteColumn(1);
                            worksheet.Cells[1, 1].Value = "Yukleme Durumu";
                            for (int i = 1; i <= rows; i++)
                            {
                                // replace occurences
                                if (worksheet.Cells[i, 1].Value.ToString() == "1")
                                    worksheet.Cells[i, 1].Value = "Kabul";
                                if (worksheet.Cells[i, 1].Value.ToString() == "2")
                                    worksheet.Cells[i, 1].Value = "Red";
                                if (worksheet.Cells[i, 1].Value.ToString() == "3")
                                    worksheet.Cells[i, 1].Value = "Beklemede";
                            }
                            package.Save();
                        }
                        MessageBox.Show("Islem Başarıyla Gerçekleşti", "Kaydetme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void paraYukleBtnNew_Click_1(object sender, EventArgs e)
        {
            var formPopup = new ParaEkleForm(_id, _ad);
            formPopup.Show();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            int islemTamam = 0 ;
            


            
            if (CbOnayla.CheckState == CheckState.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Sizden 1% vergi Tahsil edilecek \n devam etmek istermisiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (_db.SaticiVarliklari.Count() > 0)
                    {
                        int islemSayi = 0;

                        double vergi_tahsil =0;

                        int urnMik = Convert.ToInt32(TbMiktar.Text);
                        var Alici = _db.KullaniciTable.FirstOrDefault(q => q.Id == _id);
                        var saticiMinFiyat = _db.SaticiVarliklari.OrderBy(d => d.urnFiyat);

                        
                        foreach (var l in saticiMinFiyat)
                        {
                            if (l.urnFiyat <= float.Parse(fiyatTxt.Text))
                            {

                                if (l.urnAdi == CbUrun.Text)
                                {
                                    var Satici = _db.KullaniciTable.FirstOrDefault(p => p.Id == l.KullaniciId);
                                    var alim = _db.AlimSatimIslemler.Create();
                                    alim.AliciId = _id;
                                    alim.AliciAdi = Alici.KullaniciAdi;
                                    alim.SaticiId = l.KullaniciId;
                                    alim.SaticiAdi = l.KullaniciTable.Ad.ToString();
                                    alim.urnAdi = l.urnAdi;
                                    alim.Fiyat = l.urnFiyat;
                                    alim.islemZamani = DateTime.Now;
                                    vergi_tahsil = (double) (alim.Fiyat / 100);
                                    if (l.urnMiktari > 0)
                                    {
                                        if (Alici.WalletBalance >= urnMik * l.urnFiyat)
                                        {
                                            if (urnMik > l.urnMiktari)
                                            {
                                                alim.Miktar = l.urnMiktari;
                                                urnMik -= alim.Miktar;
                                                Satici.WalletBalance = Satici.WalletBalance + (alim.Miktar * l.urnFiyat);
                                                Alici.WalletBalance = Alici.WalletBalance - (alim.Miktar * l.urnFiyat);
                                                l.urnMiktari = 0;
                                                islemSayi++;
                                            }
                                            if (urnMik <= l.urnMiktari)
                                            {
                                                alim.Miktar = urnMik;
                                                l.urnMiktari = l.urnMiktari - urnMik;
                                                Satici.WalletBalance = Satici.WalletBalance + (alim.Miktar * l.urnFiyat);
                                                Alici.WalletBalance = Alici.WalletBalance - (alim.Miktar * l.urnFiyat);
                                                urnMik = 0;
                                                islemSayi++;
                                            }
                                            if (l.urnMiktari == 0)
                                            {
                                                _db.SaticiVarliklari.Remove(l);
                                            }

                                            _db.AlimSatimIslemler.Add(alim);

                                            if (alim.Miktar == 0)
                                            {
                                                _db.AlimSatimIslemler.Remove(alim);
                                            }



                                        }
                                        else // Cuzdan yetersizligi
                                        {

                                            MessageBox.Show("Cüzdanınızda Yeterli Paranız Yoktur..", "Alim Islemi Başarsız", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                            break;
                                        }


                                    }

                                }
                                else //Urun Adi 
                                {
                                    DialogResult dialogResult1 = MessageBox.Show("Şuanda Herhangi Bir Satici Yoktur... (Urun Adi) \n Bekleyen Işlemleriye eklemek istermisiniz ? ", "Alim Islemi Başarsız", MessageBoxButtons.YesNo);
                                    if (dialogResult1 == DialogResult.Yes)
                                    {
                                        var bekleyenIslemler = _db.BeklyenIslemlerTable.Create();
                                        bekleyenIslemler.AliciID = Alici.Id;
                                        bekleyenIslemler.UrunAdi = CbUrun.Text;
                                        bekleyenIslemler.UrunMiktari = Int32.Parse(TbMiktar.Text);
                                        bekleyenIslemler.UrunFiyati = float.Parse(fiyatTxt.Text);
                                        _db.BeklyenIslemlerTable.Add(bekleyenIslemler);
                                    }
                                    break;
                                }
                            }
                            else //Fiyat
                            {
                                DialogResult dialogResult1 = MessageBox.Show("Şuanda Herhangi Bir Satici Yoktur... (Fiyat)\n Bekleyen Işlemleriye eklemek istermisiniz ? ", "Alim Islemi Başarsız", MessageBoxButtons.YesNo);
                                if (dialogResult1 == DialogResult.Yes)
                                {
                                    var bekleyenIslemler = _db.BeklyenIslemlerTable.Create();
                                    bekleyenIslemler.AliciID = Alici.Id;
                                    bekleyenIslemler.UrunAdi = CbUrun.Text;
                                    bekleyenIslemler.UrunMiktari = Int32.Parse(TbMiktar.Text);
                                    bekleyenIslemler.UrunFiyati = float.Parse(fiyatTxt.Text);
                                    _db.BeklyenIslemlerTable.Add(bekleyenIslemler);


                                }
                                break;
                            }



                            islemTamam++;
                            MessageBox.Show("islemTamam :" + islemTamam + "IslemSayi : " + islemSayi);
                        }


                        if (islemTamam == islemSayi && islemSayi > 0)
                        {
                            MessageBox.Show("Alim Islemi Başarıyla Gerçekleşti ...", "Alim Islemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var muhasebeci = _db.KullaniciTable.FirstOrDefault(q => q.Id == 25);
                            if (muhasebeci != null)
                            {
                                muhasebeci.WalletBalance += vergi_tahsil;
                                Alici.WalletBalance -= vergi_tahsil;

                                MessageBox.Show("Vergi Tahsil Edildi . : " + vergi_tahsil);
                            }

                            _db.SaveChanges();

                            AlimRapor alimRapor = new AlimRapor(_id, islemSayi);
                            alimRapor.Show();


                        }
                        _db.SaveChanges();
                        RefreshLstView();


                    }
                    else //Satici Yok
                    {
                        var Alici = _db.KullaniciTable.FirstOrDefault(q => q.Id == _id);
                        DialogResult dialogResult1 = MessageBox.Show("Şuanda Herhangi Bir Satici Yoktur...(Satici) \n Bekleyen Işlemleriye eklemek istermisiniz ? ", "Alim Islemi Başarsız", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var bekleyenIslemler = _db.BeklyenIslemlerTable.Create();
                            bekleyenIslemler.AliciID = Alici.Id;
                            bekleyenIslemler.UrunAdi = CbUrun.Text;
                            bekleyenIslemler.UrunMiktari = Int32.Parse(TbMiktar.Text);
                            bekleyenIslemler.UrunFiyati = float.Parse(fiyatTxt.Text);
                            _db.BeklyenIslemlerTable.Add(bekleyenIslemler);
                            _db.SaveChanges();
                            RefreshLstView();
                        }

                      }

                    }
                }

            else
            {
                MessageBox.Show("Onaylıyorum kısmını işaretleyiniz!", "Alim Islemi Başarsız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            

            

        }
    }
}