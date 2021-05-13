using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using YZMYapimiProjesi.DB;


namespace YZMYapimiProjesi.Admin
{
    public partial class AdminAraYuzu : Form
    {
       

        private readonly DbEntity _db;
        
        public AdminAraYuzu()
        {
            InitializeComponent();
            _db = new DbEntity();
          

        }

        private void AdminAraYuzu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.AlimSatimIslemler' table. You can move, or remove it, as needed.
            this.alimSatimIslemlerTableAdapter.Fill(this.appData.AlimSatimIslemler);
            // TODO: This line of code loads data into the 'appData.KullaniciTable' table. You can move, or remove it, as needed.
            this.kullaniciTableTableAdapter.Fill(this.appData.KullaniciTable);
        }

        private void AdminAraYuzu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        Point lastPoint;

        private void AdminAraYuzu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        private void onayBekleyenBtn_Click(object sender, EventArgs e)
        {
            onayBekleyenLstFormAdmin onayBek = new onayBekleyenLstFormAdmin();
            onayBek.Show();
            Hide();
        }

        private void ParaEkTalepleriBtn_Click(object sender, EventArgs e)
        {
            ParaEklemeLstFromAdmin paraEkLst = new ParaEklemeLstFromAdmin();
            paraEkLst.Show();
            Hide();
        }
        private void KullanicilarBtn_Click(object sender, EventArgs e)
        {



            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {

                            workbook.Worksheets.Add(this.appData.KullaniciTable.CopyToDataTable(), "Kullanıcılar Listesi");
                            workbook.SaveAs(sfd.FileName);

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

        private void alimSatimRaporBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {

                            workbook.Worksheets.Add(this.appData.AlimSatimIslemler.CopyToDataTable(), "Alım Satım İşlemler");
                            workbook.SaveAs(sfd.FileName);

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
    }
}
