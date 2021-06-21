using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace YZMYapimiProjesi.Admin
{
    public partial class Alim_Satim_Rapor_Formu : Form
    {
        private AppData _appData;
        public Alim_Satim_Rapor_Formu(AppData appData)
        {
            InitializeComponent();
            this._appData = appData;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void alimSatimRaporBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Title = "Dosyaya yaz", FileName = "Rapor", Filter = "Excel File|*.xlsx|CSV File|*.csv|PDF File|*.pdf" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   string s = Path.GetFullPath(sfd.FileName);

                    if(sfd.FilterIndex == 1)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            
                            workbook.Worksheets.Add(_appData.AlimSatimIslemler.CopyToDataTable(), "Alım Satım İşlemler");
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("İslem Başarıyla Gerçekleşti", "Kaydetme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                    }
                    else if(sfd.FilterIndex == 2){
                        using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName,
                        FileMode.Create), Encoding.UTF8))
                        {
                            StringBuilder sb = new StringBuilder();
                            foreach (var p in _appData.AlimSatimIslemler)
                            {
                                sb.AppendLine($"{p.Id},{p.AliciAdi},{p.AliciId},{p.SaticiAdi},{p.SaticiId},{p.Fiyat},{p.Miktar},{p.urnAdi},{p.islemZamani}");
                            }
                            sw.Write(sb.ToString());
                        }
                    }
                    else if (sfd.FilterIndex==3)
                    {
                        string path = Path.GetFullPath(sfd.FileName);

                       
                            Document doc = new Document(PageSize.A4);
                            var output = new FileStream(path, FileMode.Create);
                            var writer = PdfWriter.GetInstance(doc, output);
                            doc.Open();


                            PdfPTable table1 = new PdfPTable(9);
                            

                            var HeaderFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8);
                            var cellFont = new Font(iTextSharp.text.Font.NORMAL, 5);

                            table1.AddCell(new Phrase("ID", HeaderFont));
                            table1.AddCell(new Phrase("ALICI ADI", HeaderFont));
                            table1.AddCell(new Phrase("ALICI ID", HeaderFont));
                            table1.AddCell(new Phrase("SATICI ADI", HeaderFont));
                            table1.AddCell(new Phrase("SATICI ID", HeaderFont));
                            table1.AddCell(new Phrase("FIYAT", HeaderFont));
                            table1.AddCell(new Phrase("MIKTAR", HeaderFont));
                            table1.AddCell(new Phrase("URUN ADI", HeaderFont));
                            table1.AddCell(new Phrase("TARIH", HeaderFont));

                            foreach (var i in this._appData.AlimSatimIslemler)
                            {
                                table1.AddCell(new Phrase(i.Id.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.AliciAdi, cellFont));
                                table1.AddCell(new Phrase(i.AliciId.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.SaticiAdi, cellFont));
                                table1.AddCell(new Phrase(i.SaticiId.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.Fiyat.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.Miktar.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.urnAdi, cellFont));
                                table1.AddCell(new Phrase(i.islemZamani.ToString(), cellFont));
                            }

                            doc.Add(table1);
                            
                            doc.Close();

                        
                    }
                   
                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ozlListle_btn_Click(object sender, EventArgs e)
        {

            if (  CB_urunTipi.Text == "" )
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog() { Title = "Dosyaya yaz", FileName = "Rapor", Filter = "Excel File|*.xlsx|CSV File|*.csv|PDF File|*.pdf" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string s = Path.GetFullPath(sfd.FileName);

                        if (sfd.FilterIndex == 1)
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(_appData.AlimSatimIslemler.Where(q => q.islemZamani >= DTP_BaslangicTarih.Value && q.islemZamani <= DTP_BitisTarih.Value &&q.urnAdi ==  CB_urunTipi.Text ).CopyToDataTable(), "Alım Satım İşlemler");
                                workbook.SaveAs(sfd.FileName);
                                MessageBox.Show("İslem Başarıyla Gerçekleşti", "Kaydetme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                            }
                        }
                        else if (sfd.FilterIndex == 2)
                        {
                            using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName,
                            FileMode.Create), Encoding.UTF8))
                            {
                                StringBuilder sb = new StringBuilder();
                                foreach (var p in _appData.AlimSatimIslemler.Where(q => q.islemZamani >= DTP_BaslangicTarih.Value && q.islemZamani <= DTP_BitisTarih.Value && q.urnAdi == CB_urunTipi.Text))
                                {
                                    sb.AppendLine($"{p.Id},{p.AliciAdi},{p.AliciId},{p.SaticiAdi},{p.SaticiId},{p.Fiyat},{p.Miktar},{p.urnAdi},{p.islemZamani}");
                                }
                                sw.Write(sb.ToString());
                            }
                        }
                        else if (sfd.FilterIndex == 3)
                        {
                            string path = Path.GetFullPath(sfd.FileName);


                            Document doc = new Document(PageSize.A4);
                            var output = new FileStream(path, FileMode.Create);
                            var writer = PdfWriter.GetInstance(doc, output);
                            doc.Open();


                            PdfPTable table1 = new PdfPTable(9);


                            var HeaderFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8);
                            var cellFont = new Font(iTextSharp.text.Font.NORMAL, 5);

                            table1.AddCell(new Phrase("ID", HeaderFont));
                            table1.AddCell(new Phrase("ALICI ADI", HeaderFont));
                            table1.AddCell(new Phrase("ALICI ID", HeaderFont));
                            table1.AddCell(new Phrase("SATICI ADI", HeaderFont));
                            table1.AddCell(new Phrase("SATICI ID", HeaderFont));
                            table1.AddCell(new Phrase("FIYAT", HeaderFont));
                            table1.AddCell(new Phrase("MIKTAR", HeaderFont));
                            table1.AddCell(new Phrase("URUN ADI", HeaderFont));
                            table1.AddCell(new Phrase("TARIH", HeaderFont));

                            foreach (var i in this._appData.AlimSatimIslemler.Where(q => q.islemZamani >= DTP_BaslangicTarih.Value && q.islemZamani <= DTP_BitisTarih.Value && q.urnAdi == CB_urunTipi.Text))
                            {
                                table1.AddCell(new Phrase(i.Id.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.AliciAdi, cellFont));
                                table1.AddCell(new Phrase(i.AliciId.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.SaticiAdi, cellFont));
                                table1.AddCell(new Phrase(i.SaticiId.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.Fiyat.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.Miktar.ToString(), cellFont));
                                table1.AddCell(new Phrase(i.urnAdi, cellFont));
                                table1.AddCell(new Phrase(i.islemZamani.ToString(), cellFont));
                            }

                            doc.Add(table1);

                            doc.Close();

                        }




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
