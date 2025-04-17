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
    public partial class Nhanvien : UserControl
    {
        private  NhanVienBUS bus;
        public Nhanvien()
        {
            InitializeComponent();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            Load_datagrid();

        }
        private void Load_datagrid()
        {
            bus = new NhanVienBUS();

            List<NhanVienDTO> list = bus.docDsnv();
            DataNhanvien.AutoGenerateColumns = false;
            DataNhanvien.Columns["ID"].DataPropertyName = "Manhanvien";
            DataNhanvien.Columns["Ten"].DataPropertyName = "Hoten";
            DataNhanvien.Columns["phone"].DataPropertyName = "Sdt";
            DataNhanvien.Columns["Address"].DataPropertyName = "Diachi";
            DataNhanvien.Columns["Account"].DataPropertyName = "Taikhoan";
            DataNhanvien.Columns["Password"].DataPropertyName = "Matkhau";
            DataNhanvien.Columns["Email"].DataPropertyName = "Email";
            DataNhanvien.Columns["Chucvu"].DataPropertyName = "Chucvu";
            DataNhanvien.Columns["Trangthai"].DataPropertyName = "Trangthai";

            DataNhanvien.DataSource = list;

           
        }
    }
}
