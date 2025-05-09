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
        public Xulyvipham(string[] data)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            TvvpTbx.Text = data[0];
            TenvpTbx.Text = data[1];
            MotaTbx.Text = data[2];
            TrangthaiCbx.SelectedIndex = data[3] == "Chua xu ly" ? 0 : 1;
            Mavp = data[4];
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XulyBtn_Click(object sender, EventArgs e)
        {
            if (viPhamBUS.XulyViPham(Mavp))
                MessageBox.Show("Xử lý thành công");
            else
                MessageBox.Show("Xử lý thất bại");
            this.Close();
        }
    }
}
