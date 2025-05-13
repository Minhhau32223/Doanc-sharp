using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doanc_sharp.src.BUS;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string taikhoan = accountTbox.Text.Trim();
            string matkhau = passwordTbox.Text.Trim();

            NhanVienBUS bus = new NhanVienBUS();
            NhanVienDTO nv = bus.DangNhap(taikhoan, matkhau);

            if (nv != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.setTaikhoan(nv.Taikhoan.ToString());
                
                // Truyền nhân viên qua nếu cần
                mainForm.ShowDialog();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
