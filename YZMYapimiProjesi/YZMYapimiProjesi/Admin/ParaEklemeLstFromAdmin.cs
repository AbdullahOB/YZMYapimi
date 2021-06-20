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
    public partial class ParaEklemeLstFromAdmin : Form
    {
        private readonly DbEntity _db;

        public ParaEklemeLstFromAdmin()
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

        private void ParaEklemeLstFromAdmin_Load(object sender, EventArgs e)
        {
            var reqList = _db.RequestTable.ToList();
            foreach (var l in reqList)
            {
                if (l.statueId == 3)
                {
                    ListViewItem addReq = new ListViewItem(l.Id.ToString());
                    addReq.SubItems.Add(l.KullaniciId.ToString());
                    addReq.SubItems.Add(l.MsgSubject);
                    paraEklemeTalepleriLst.Items.Add(addReq);
                }


            }

        }

        private void paraEklemeTalepleriLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int reqId = Convert.ToInt32(paraEklemeTalepleriLst.SelectedItems[0].Text);
            ParaEkle paraekle = new ParaEkle(reqId);
            paraekle.Show();
            this.Hide();
        }
    }
}
