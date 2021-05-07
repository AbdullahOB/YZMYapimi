using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZMYapimiProjesi.Admin
{
    public partial class KullanicilarExport : Form
    {
        public KullanicilarExport()
        {
            InitializeComponent();
        }

        private void export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.appData.Table.CopyToDataTable() , "Kullanicilar Listesi");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Excel Dosyayı başırı ile oluşturuldu ..." , "Message", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void KullanicilarExport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.appData.Table);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
