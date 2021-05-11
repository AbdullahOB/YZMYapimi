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
        private readonly DbEntity _db;
        public SaticiForm(int id)
        {
            InitializeComponent();
            _db = new DbEntity();
            _id = id;
           
            
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
            UrunEkForm obj = new UrunEkForm(_id);
            obj.Show();
            
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SaticiForm_Load(object sender, EventArgs e)
        {
            var stoktaUrn = _db.SaticiVarliklari.ToList();
            foreach (var l in stoktaUrn)
            {
               
                    ListViewItem addStok = new ListViewItem(l.urnAdi.ToString());
                addStok.SubItems.Add(l.urnMiktari.ToString());
                addStok.SubItems.Add(l.urnFiyat.ToString());
                stoktaLst.Items.Add(addStok);
               


            }

            var onayBekleyen = _db.SaticiRequest.ToList();
            
                foreach (var l in onayBekleyen)
                {
                if(l.StatueId == 2)
                {
                    ListViewItem addStok = new ListViewItem(l.Id.ToString());
                    addStok.BackColor = Color.Red;
                    addStok.ForeColor = Color.White;
                    addStok.SubItems.Add(l.urnAdi);
                    addStok.SubItems.Add(l.urnMiktari.ToString());
                    addStok.SubItems.Add(l.urnFiyati.ToString());
                  
                    onayBekleyenUrnLst.Items.Add(addStok);
                    

                }

                else if(l.StatueId == 3)
                {
                    ListViewItem addStok = new ListViewItem(l.Id.ToString());
                    addStok.SubItems.Add(l.urnAdi);
                    addStok.SubItems.Add(l.urnMiktari.ToString());
                    addStok.SubItems.Add(l.urnFiyati.ToString());
                    onayBekleyenUrnLst.Items.Add(addStok);
                }

                   



                }
            
            

        }

        private void onayBekleyenUrnLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int reqIds = Convert.ToInt32(onayBekleyenUrnLst.SelectedItems[0].Text);
            
            DuzetlmeFormu duzetlmeFormu = new DuzetlmeFormu(reqIds);
            duzetlmeFormu.Show();
            Hide();
                
         }
    }
}
