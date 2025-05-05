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
    }
}
