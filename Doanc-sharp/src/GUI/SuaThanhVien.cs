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
    public partial class SuaThanhVien : Form
    {
        private ThanhVienDTO thanhVien;
        private bool isEdit;

        public SuaThanhVien() { }
        public SuaThanhVien(ThanhVienDTO tv)
        {
            InitializeComponent();
            thanhVien = tv;
            isEdit = true;
            LoadDuLieuThanhVien(tv);
        }
        public void LoadDuLieuThanhVien(ThanhVienDTO tv)
        {
            idTbox.Text = tv.Mathanhvien.ToString();
            idTbox.ReadOnly = true;
            nameTbox.Text = tv.Hoten;
            phoneTbox.Text = tv.Sdt.ToString();
            addressTbox.Text = tv.Diachi;
            dtpNgaydangky.Value = tv.Ngaydangky;
            emailTbox.Text = tv.Email;
            statusTbox.Text = tv.Trangthai;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SuaThanhVien_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTbox.Text) ||
     string.IsNullOrWhiteSpace(emailTbox.Text) ||
     string.IsNullOrWhiteSpace(phoneTbox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên, email và số điện thoại.");
                return;
            }

            if (!int.TryParse(phoneTbox.Text, out int sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số.");
                return;
            }

            if (thanhVien == null)
            {
                MessageBox.Show("Không tìm thấy thông tin thành viên cần cập nhật.");
                return;
            }

            // Hỏi người dùng có muốn cập nhật không
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin thành viên này?",
                                                   "Xác nhận cập nhật",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return; // Người dùng chọn No
            }

            // Gán lại dữ liệu mới
            thanhVien.Hoten = nameTbox.Text.Trim();
            thanhVien.Sdt = sdt;
            thanhVien.Ngaydangky = dtpNgaydangky.Value;
            thanhVien.Diachi = addressTbox.Text.Trim();
            thanhVien.Email = emailTbox.Text.Trim();
            thanhVien.Trangthai = statusTbox.Text.Trim();

            // Cập nhật vào cơ sở dữ liệu
            ThanhVienBUS tvBUS = new ThanhVienBUS();
            bool result = tvBUS.CapNhatThanhVien(thanhVien);

            if (result)
            {
                MessageBox.Show("Cập nhật thành công.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
            }

        }
        public ThanhVienDTO LayDulieu()
        {
            return thanhVien;
        }
    }
}
