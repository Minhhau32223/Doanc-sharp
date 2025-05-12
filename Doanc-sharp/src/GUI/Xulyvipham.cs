using Doanc_sharp.src.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doanc_sharp
{
    public partial class Xulyvipham : Form
    {
        ViPhamBUS viPhamBUS = new ViPhamBUS();
        String Mavp;
        int maThanhVien;
        public Xulyvipham(string[] data)
        {
            InitializeComponent();
            hinhThucXuLyCbx.SelectedIndex = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            TvvpTbx.Text = data[0];
            TenvpTbx.Text = data[1];
            MotaTbx.Text = data[2];
            TrangthaiCbx.SelectedIndex = data[3] == "Chua xu ly" ? 0 : 1;
            Mavp = data[4];
            maThanhVien = int.Parse(data[5]);
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XulyBtn_Click(object sender, EventArgs e)
        {
            DateTime timeUnlock = DateTime.Now;
            DateTime now = DateTime.Now;
            //{ "Cảnh cáo", "Khóa thẻ 1 ngày", "Khóa thẻ 3 ngày", "Khóa thẻ 7 ngày", "Khóa thẻ 1 tháng", "Khóa thẻ 1 năm", "Khóa thẻ vĩnh viễn" }
            switch (hinhThucXuLyCbx.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    timeUnlock = now.AddDays(1);
                    break;
                case 2:
                    timeUnlock = now.AddDays(3);
                    break;
                case 3:
                    timeUnlock = now.AddDays(7);
                    break;
                case 4:
                    timeUnlock = now.AddMonths(1);
                    break;
                case 5:
                    timeUnlock = now.AddYears(1);
                    break;
                case 6:
                    timeUnlock = DateTime.MaxValue;
                    break;
                default:
                    MessageBox.Show("Chưa chọn hình thức xử lý");
                    return;
            }
            if (viPhamBUS.XulyViPham(Mavp, maThanhVien, timeUnlock))
                MessageBox.Show("Xử lý thành công");
            else
                MessageBox.Show("Xử lý thất bại");
            this.Close();
        }
    }
}
