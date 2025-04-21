using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (string.IsNullOrWhiteSpace(nameTbox.Text) || string.IsNullOrWhiteSpace(emailTbox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và email.");
                return;
            }

            if (thanhVien == null)
                thanhVien = new ThanhVienDTO();
            thanhVien.Hoten = nameTbox.Text;
            thanhVien.Sdt = int.Parse(phoneTbox.Text);
            thanhVien.Ngaydangky = dtpNgaydangky.Value;
            thanhVien.Diachi = addressTbox.Text;
            thanhVien.Email = emailTbox.Text;
            thanhVien.Trangthai = statusTbox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public ThanhVienDTO LayDulieu()
        {
            return thanhVien;
        }
    }
}
