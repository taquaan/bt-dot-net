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
    public partial class FrmDangNhap : Form
    {
        private KetNoiCSDL kn = new KetNoiCSDL();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = textTen.Text;
            string pass = textMatKhau.Text;

            string sql = $"SELECT COUNT(1) FROM DANGNHAP WHERE TENDN = '{username}' AND MATKHAU = '{pass}'";
            DataTable result = kn.Lay_Dulieu(sql);
            int count = Convert.ToInt32(result.Rows[0][0]);
            if (count >= 1)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmAll taisanForm = new FrmAll();
                taisanForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao != DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
