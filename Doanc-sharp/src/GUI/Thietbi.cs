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
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;
using MySqlX.XDevAPI.Common;
namespace Doanc_sharp
{
    public partial class Thietbi : UserControl
    {
        private ThietBiBUS tbBUS;
        public Thietbi()
        {
            InitializeComponent();
            tbBUS = new ThietBiBUS();
            LoadData();
        }
        public void LoadData()
        {
            dgvThietbi.DataSource = tbBUS.LayDanhSachThietBi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Thietbi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThietBi formThem = new ThemThietBi();
            if (formThem.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (dgvThietbi.CurrentRow != null)
            {
                ThietBiDTO selected = new ThietBiDTO()
                {
                    Mathietbi = Convert.ToInt32(dgvThietbi.CurrentRow.Cells["Mathietbi"]),
                    Tenthietbi = dgvThietbi.CurrentRow.Cells["Tenthietbi"].ToString(),
                    Madanhmuc = dgvThietbi.CurrentRow.Cells["Madanhmuc"].ToString(),
                    Giathue = Convert.ToInt32(dgvThietbi.CurrentRow.Cells["Giathue"]),
                    Trangthai = dgvThietbi.CurrentRow.Cells["Trangthai"].ToString(),
                };
                SuaThietBi formThem = new SuaThietBi();
                if (formThem.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThietbi.CurrentRow == null)
            {
                int id = Convert.ToInt32(dgvThietbi.CurrentRow.Cells["Mathietbi"]);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (tbBUS.XoaThietBi(id))
                    {
                        MessageBox.Show("Xoá thành công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại");
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
