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

namespace YZMYapimiProjesi.Alici
{
    public partial class AlimRapor : Form
    {
        private string msg;
        private string urun = "Yulaf";
        private int miktar = 4 ;
        private int fiyat = 100;

        public AlimRapor(string Urun, int Miktar)
        {
            InitializeComponent();

            // Do this when evry thing done

            //this.urun = Urun;
            //this.miktar = Miktar;


            msg = "Alınan Ürün: " + urun + ", Miktarı: " + miktar + " (kg), Alış Fiyatı: " + fiyat+ " TL";
            TbUrunBilgi.Text = msg;

        }


        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Dekont", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10,10));
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(700, 10));
            e.Graphics.DrawString("_________________________________________________________________________________", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 50));
            e.Graphics.DrawString(TbUrunBilgi.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10,100));
        }
        private void PbSave_Click(object sender, EventArgs e)
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

    }
}
