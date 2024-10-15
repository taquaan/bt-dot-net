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
    public partial class FrmDieuChuyen : Form
    {
        private KetNoiCSDL kn = new KetNoiCSDL();
        public FrmDieuChuyen()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string sql = "SELECT * FROM DIEUCHUYEN";
            DataTable dt = kn.Lay_Dulieu(sql); // Use your method to get data
            dataGridView1.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string madc = textMaDC.Text;
            string mats = textMaTaiSan.Text;
            string ngaydc = textNgay.Text; // Ensure this is in the correct format
            string mapb_dc = textMaPhongBan.Text;
            string tinhtrang = textTinhTrang.Text;

            string sql = $"INSERT INTO DIEUCHUYEN (MADC, MATS, NGAYDC, MAPB_DC, TINHTRANG) VALUES ('{madc}', '{mats}', '{ngaydc}', '{mapb_dc}', '{tinhtrang}')";
            kn.ThucThi(sql); 
            LoadData(); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madc = textMaDC.Text;
            string mats = textMaTaiSan.Text;
            string ngaydc = textNgay.Text;
            string mapb_dc = textMaPhongBan.Text;
            string tinhtrang = textTinhTrang.Text;

            string sql = $"UPDATE DIEUCHUYEN SET MATS = '{mats}', NGAYDC = '{ngaydc}', MAPB_DC = '{mapb_dc}', TINHTRANG = '{tinhtrang}' WHERE MADC = '{madc}'";
            kn.ThucThi(sql); 
            LoadData(); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string madc = textMaDC.Text;
            string mats = textMaTaiSan.Text;

            string sql = $"DELETE FROM DIEUCHUYEN WHERE MADC = '{madc}'";
            kn.ThucThi(sql);
            LoadData();
        }

        private void FrmDieuChuyen_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmAll frmAll = new FrmAll();
            frmAll.Show();
            this.Close();
        }
    }
}
