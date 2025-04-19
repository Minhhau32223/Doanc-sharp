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
            //QuetMaVach quetMaVach = new QuetMaVach();
            //quetMaVach.Show();
            var formQuet = new QuetMaVach();
            formQuet.MaVachQuetThanhCong += (maVach) =>
            {
                kiemTraMaTV(int.Parse(maVach));
            };
            formQuet.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(enterMTV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vạch.");
                return;
            }

            int matv;
            if (!int.TryParse(enterMTV.Text.Trim(), out matv))
            {
                MessageBox.Show("Mã vạch không hợp lệ. Vui lòng nhập lại.");
                return;
            }
            kiemTraMaTV(matv);
        }


        public void kiemTraMaTV(int matv)
        {
            int kiemtra = kiemTraBUS.KiemTraTruocKhiVao(matv);
            switch (kiemtra)
            {
                case 1:
                    MessageBox.Show("Kiểm tra thành công.");
                    break;
                case -1:
                    MessageBox.Show("Thành viên vi phạm!");
                    break;
                case -2:
                    MessageBox.Show("Mã thành viên không hợp lệ.");
                    break;
                default:
                    MessageBox.Show("Có l���i xảy ra trong quá trình kiểm tra.");
                    break;
            }
        }

        private void onInput(object sender, EventArgs e)
        {
            enterMTV.Text = "";
            enterMTV.ForeColor = Color.Black;
        }
    }
}
