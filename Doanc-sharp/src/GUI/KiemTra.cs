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

namespace Doanc_sharp.src.GUI
{
    public partial class KiemTra : UserControl
    {
        private KiemTraBUS kiemTraBUS = new KiemTraBUS();
        public KiemTra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuetMaVach quetMaVach = new QuetMaVach();
            quetMaVach.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaVach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vạch.");
                return;
            }
            int kiemtra = kiemTraBUS.KiemTraTruocKhiVao(int.Parse(txtMaVach.Text));
            if (kiemtra == 1)
            {
                MessageBox.Show("Kiểm tra thành công.");
            }
            else if (kiemtra == -1)
            {
                MessageBox.Show("Mã vạch không hợp lệ.");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình kiểm tra.");
            }
        }
    }
}
