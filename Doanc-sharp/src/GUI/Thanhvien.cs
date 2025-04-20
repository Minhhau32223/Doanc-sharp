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
using Doanc_sharp.src.DAO;
namespace Doanc_sharp
{
    public partial class Thanhvien : UserControl
    {
        private ThanhVienBUS tvBUS = new ThanhVienBUS();
        public Thanhvien()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SuaThanhVien suaThanhVien = new SuaThanhVien();

        }
        private void LoadData()
        {
            DataThanhvien.DataSource = tvBUS.LayTatcaThanhVien();
        }

        private void Thanhvien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataThanhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (DataThanhvien.SelectedRows.Count > 0)
            {
                int rowIndex = DataThanhvien.SelectedRows[0].Index;
                ThanhVienDTO tv = (ThanhVienDTO)DataThanhvien.Rows[rowIndex].DataBoundItem;

                SuaThanhVien f = new SuaThanhVien();
                f.LoadDuLieuThanhVien(tv);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn thành viên");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DataThanhvien.SelectedRows.Count > 0)
            {
                int rowIndex = DataThanhvien.SelectedRows[0].Index;
                ThanhVienDTO tv = (ThanhVienDTO)DataThanhvien.Rows[rowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                SuaThanhVien f = new SuaThanhVien();
                f.LoadDuLieuThanhVien(tv);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    tvBUS.XoaThanhVien(tv.Mathanhvien);
                    LoadData();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn thành viên");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
