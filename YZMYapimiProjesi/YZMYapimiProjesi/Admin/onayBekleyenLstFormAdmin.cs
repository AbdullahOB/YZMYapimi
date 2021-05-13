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

namespace YZMYapimiProjesi.Admin
{
    public partial class onayBekleyenLstFormAdmin : Form
    {
        private readonly DbEntity _db;
        public onayBekleyenLstFormAdmin()
        {
            InitializeComponent();
            _db = new DbEntity();
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
           AdminAraYuzu adminAra = new AdminAraYuzu();
           adminAra.Show();
           Hide();
        }

        private void onayBekleyenLstFormAdmin_Load(object sender, EventArgs e)
        {
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

        private void onayBekleyenUrnLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int reqId = Convert.ToInt32(onayBekleyenUrnLst.SelectedItems[0].Text);
            UrnBilgileri urnBilgiler = new UrnBilgileri(reqId);
            urnBilgiler.Show();
            this.Hide();
        }
    }
}
