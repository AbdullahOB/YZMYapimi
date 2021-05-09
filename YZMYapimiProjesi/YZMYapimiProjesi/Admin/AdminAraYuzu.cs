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



namespace YZMYapimiProjesi.Admin
{
    public partial class AdminAraYuzu : Form
    {
        public AdminAraYuzu()
        {
            InitializeComponent();
        }

        private void AdminAraYuzu_Load(object sender, EventArgs e)
        {
              
                
        }

        private void geriDonButonu(object sender, EventArgs e)
        {

        }

        private void kullanicilarListesiKaydet(object sender, EventArgs e)
        {
           
           

           
        }


        private void alimSatimRaporuKaydet(object sender, EventArgs e)
        {

        }

      


        private void ExitBtnFun(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aliciParaEklemeLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParaEkle paraEkle =new ParaEkle();


            int index;
            string item;
           
                foreach (int i in aliciParaEklemeLst.SelectedIndices)
                {
                    index = aliciParaEklemeLst.SelectedIndex;
                    item = aliciParaEklemeLst.Items[i].ToString();
                    paraEkle.Show();
                    
                   
                }

            

        }

        private void onayBekleyenUrnLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrnBilgileri urnBilgileri = new UrnBilgileri();


            int index;
            string item;
            
                foreach (int i in aliciParaEklemeLst.SelectedIndices)
                {
                    index = aliciParaEklemeLst.SelectedIndex;
                    item = aliciParaEklemeLst.Items[i].ToString();
                    urnBilgileri.Show();
                }
            
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
