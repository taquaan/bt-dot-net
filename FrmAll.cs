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
    public partial class FrmAll : Form
    {
        public FrmAll()
        {
            InitializeComponent();
        }

        private void btnDieuChuyen_Click(object sender, EventArgs e)
        {
            FrmDieuChuyen frmTaiSan = new FrmDieuChuyen();
            frmTaiSan.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmThongTinDC frmThongTinDC = new FrmThongTinDC();  
            frmThongTinDC.Show();
            this.Close( );  
        }
    }
}
