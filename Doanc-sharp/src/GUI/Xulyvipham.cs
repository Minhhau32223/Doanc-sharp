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
        public Xulyvipham(string[] data)
        {
            InitializeComponent();
            //TvvpCbx.SelectedIndex = TvvpCbx.FindStringExact(data[0]);
            TenvpTbx.Text = data[1];
            MotaTbx.Text = data[2];
            TrangthaiCbx.SelectedIndex = data[3] == "chua xu ly" ? 0 : 1;
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void XulyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xử lý thành công(Thực ra chưa làm)");
        }
    }
}
