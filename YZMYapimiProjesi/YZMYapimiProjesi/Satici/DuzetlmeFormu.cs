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
    public partial class DuzetlmeFormu : Form
    {
        private readonly DbEntity _db;
        private int _id;
        
        public DuzetlmeFormu(int reqId)
        {
            InitializeComponent();
          
            _id = reqId;
            _db = new DbEntity();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DuzetlmeFormu_Load(object sender, EventArgs e)
        {
            

            var reqRed = _db.SaticiRequest.Find(_id);
            var redMsg = reqRed.MessageFromAdmin;
            redSebebiTxt.Text = redMsg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaticiForm saticiForm = new SaticiForm(_id);
            saticiForm.Show();

            Hide();
        }
    }
}
