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
using Doanc_sharp.src.Helpers;
namespace Doanc_sharp
{
    public partial class Thanhvien : UserControl
    {
        private ThanhVienBUS tvBUS = new ThanhVienBUS();
        private Tools tools = new Tools();
        public Thanhvien()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {


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

                SuaThanhVien f = new SuaThanhVien(tv);
              
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

                if (result == DialogResult.Yes)
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Chọn file CSV danh sách thành viên";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    if (lines.Length <= 1)
                    {
                        MessageBox.Show("File không có dữ liệu hợp lệ.");
                        return;
                    }

                    int thanhCong = 0, thatBai = 0;
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');
                        if (fields.Length < 8)
                        {
                            thatBai++;
                            continue;
                        }

                        try
                        {
                            ThanhVienDTO tv = new ThanhVienDTO
                            { Mathanhvien = tools.GenerateUniqueNumber("thanhvien", "Mathanhvien"),
                                Hoten = fields[0],
                                Taikhoan = fields[1],
                                Matkhau = fields[2],
                                Diachi = fields[3],
                                Sdt = int.Parse(fields[4]),
                                Ngaydangky = DateTime.Parse(fields[5]),
                                Trangthai = fields[6],
                                Email = fields[7]
                                // Mathanhvien sẽ do DB tự sinh nếu dùng AUTO_INCREMENT
                            }; ;

                            bool result = tvBUS.ThemThanhVien(tv);
                    
                            if (result)
                                thanhCong++;
                            else
                                thatBai++;
                        }
                        catch
                        {
                            thatBai++;
                        }
                    }

                    MessageBox.Show($"Nhập thành công {thanhCong} thành viên. Thất bại {thatBai} dòng.");
                    LoadData(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                }
            }


        }
    }
}
