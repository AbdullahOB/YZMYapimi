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


            var reqList = _db.RequestTables.ToList();
            foreach(var l in reqList)
            {
                if(l.statueId == 3)
                {
                    ListViewItem addReq = new ListViewItem(l.Id.ToString());
                    addReq.SubItems.Add(l.KullaniciId.ToString());
                    addReq.SubItems.Add(l.MsgSubject);
                    ParaEklemeLst.Items.Add(addReq);
                }
                
             
            }


            var SatReq = _db.SaticiRequest.ToList();
            foreach (var l in SatReq)
            {
                if (l.StatueId == 3)
                {
                    ListViewItem addReqSat = new ListViewItem(l.Id.ToString());
                    addReqSat.SubItems.Add(l.KullaniciId.ToString());
                    addReqSat.SubItems.Add(l.Message);
                    onayBekleyenUrnLst.Items.Add(addReqSat);
                }


            }

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

       
        private void onayBekleyenUrnLst_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ParaEklemeLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void ParaEklemeLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            int reqId = Convert.ToInt32(ParaEklemeLst.SelectedItems[0].Text) ;
            
           

            ParaEkle paraekle = new ParaEkle(reqId);
            paraekle.Show();
            this.Hide();
            

        }

        private void onayBekleyenUrnLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int reqId = Convert.ToInt32(onayBekleyenUrnLst.SelectedItems[0].Text);



            UrnBilgileri urnBilgiler = new UrnBilgileri(reqId);
            urnBilgiler.Show();
            this.Hide();
        }
    }
}
