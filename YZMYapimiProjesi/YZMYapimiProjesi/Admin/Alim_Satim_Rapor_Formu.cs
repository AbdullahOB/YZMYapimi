using ClosedXML.Excel;
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
            SaveFileDialog sfd = new SaveFileDialog() { Title = "Dosyaya yaz", FileName = "Rapor", Filter = "Excel File|*.xlsx|CSV File|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        workbook.Worksheets.Add(_appData.AlimSatimIslemler.CopyToDataTable(), "Alım Satım İşlemler");
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("İslem Başarıyla Gerçekleşti", "Kaydetme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
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

            if (CB_islemTipi.Text == "" || CB_urunTipi.Text == "" )
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CB_islemTipi.Text == "Alim")
                {



                    


                }
                else if (CB_islemTipi.Text == "Satim")
                {

                    


                }
            }
        }
    }
}
