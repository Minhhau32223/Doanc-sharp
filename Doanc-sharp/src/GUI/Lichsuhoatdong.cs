using Doanc_sharp.src.BUS;
using Doanc_sharp.src.DTO;
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
    public partial class Lichsuhoatdong : UserControl
    {
        private LSHoatDongBUS lshdBUS = new LSHoatDongBUS();
        public Lichsuhoatdong()
        {
            InitializeComponent();
            cbxFilter.SelectedIndex = 0;
            LoadData();
        }
        public void LoadData()
        {
            DataTable dt = lshdBUS.GetAllLSHoatDong();
            dataGridView1.DataSource = dt;
        }


        private void onFocus(object sender, EventArgs e)
        {
            if (FindTbx.Text == "Tìm kiếm...")
            {
                FindTbx.Text = "";
                FindTbx.ForeColor = Color.Black;
            }
        }

        private void onBlur(object sender, EventArgs e)
        {
            if (FindTbx.Text == "")
            {
                FindTbx.Text = "Tìm kiếm...";
                FindTbx.ForeColor = Color.Gray;
            }
        }

        private void onClick(object sender, MouseEventArgs e)
        {
            string findData = FindTbx.Text.Trim();

            if (string.IsNullOrEmpty(findData) || findData == "Tìm kiếm...")
            {
                LoadData(); // Nếu rỗng hoặc mặc định thì load toàn bộ
            }
            else
            {
                DataTable dt = lshdBUS.TimKiemLSHoatDong(findData);
                dataGridView1.DataSource = dt;
            }
        }

        private void checkEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string findData = FindTbx.Text.Trim();

                if (string.IsNullOrEmpty(findData) || findData == "Tìm kiếm...")
                {
                    LoadData();
                }
                else
                {
                    DataTable dt = lshdBUS.TimKiemLSHoatDong(findData);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void Lichsuhoatdong_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void onChange(object sender, EventArgs e)
        {
            //new object[] { "Tất cả", "Hôm nay", "Ba ngày trước", "Một tuần trước", "Một tháng trước", "Một năm trước" }
            Object time = cbxFilter.Items;
            DateTime timeNow = DateTime.Now;
            DateTime timeFilter = timeNow;
            switch (cbxFilter.SelectedIndex)
            {
                case 0:
                    LoadData();
                    return;
                case 1:
                    timeFilter = timeNow.AddDays(-1);
                    break;
                case 2:
                    timeFilter = timeNow.AddDays(-3);
                    break;
                case 3:
                    timeFilter = timeNow.AddDays(-7);
                    break;
                case 4:
                    timeFilter = timeNow.AddMonths(-1);
                    break;
                case 5:
                    timeFilter = timeNow.AddYears(-1);
                    break;
            }
            if(timeFilter == timeNow) { 
                LoadData();
                return;
            }
            DataTable dt = lshdBUS.filterLSHDByTime(timeFilter);
            dataGridView1.DataSource = dt;
        }
    }
}
