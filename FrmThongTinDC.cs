using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemTraTaQuan
{
    public partial class FrmThongTinDC : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmThongTinDC()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            string sql = "SELECT * FROM DIEUCHUYEN";
            DataTable dt = kn.Lay_Dulieu(sql); // Use your method to get data
            dataGridView1.DataSource = dt;
        }

        private void FrmThongTinDC_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;
            string sql = $"SELECT * FROM DIEUCHUYEN WHERE MADC LIKE '%{searchTerm}%' OR MATS LIKE '%{searchTerm}%'";
            DataTable dt = kn.Lay_Dulieu(sql); 
            dataGridView1.DataSource = dt; 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmAll frmAll = new FrmAll();
            frmAll.Show();
            this.Close();
        }
    }
}
