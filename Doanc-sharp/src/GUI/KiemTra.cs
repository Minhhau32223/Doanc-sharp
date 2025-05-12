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
using Doanc_sharp.src.Helpers;
namespace Doanc_sharp.src.GUI
{
    public partial class KiemTra : UserControl
    {
        private KiemTraBUS kiemTraBUS = new KiemTraBUS();
        private ThanhVienBUS tvbus;
        private Tools tools;
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
                try
                {
                    kiemTraMaTV(int.Parse(maVach));
                }
                catch (Exception e)
                {
                }
            };
            formQuet.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(enterMTV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thành viên");
                return;
            }

            int matv;
            if (!int.TryParse(enterMTV.Text.Trim(), out matv))
            {
                MessageBox.Show("Mã thành viên không hợp lệ. Vui lòng nhập lại.");
                return;
            }
            kiemTraMaTV(matv);
        }


        public void kiemTraMaTV(int matv)
        {
            Dictionary<int, string> kiemtra = kiemTraBUS.KiemTraTruocKhiVao(matv);
            var result = kiemtra.First(); // result.Key, result.Value
            MessageBox.Show(result.Value);
            if(result.Key==200)
            {
                tvbus = new ThanhVienBUS();
                ThanhVienDTO temp = tvbus.TimThanhVienTheoMa(matv);
                textInforMa.Text = temp.Mathanhvien.ToString();
                textInforNgaydk.Text = temp.Ngaydangky.ToString();
                textInforEmail.Text = temp.Email.ToString();
                textInforDiachi.Text = temp.Diachi.ToString();
                textInforCheckin.Text = DateTime.Now.ToString();
                textInforTen.Text = temp.Hoten.ToString();
                textInforSdt.Text = temp.Sdt.ToString();
            }
        }


        public void themLichSuHD(int matv, string status)
        {
            tools = new Tools();
            int mahd = tools.GenerateUniqueNumber("lichsuhoatdong", "Mahoatdong");
            LSHoatDongDTO lichSuHD = new LSHoatDongDTO(matv, mahd,"Vào thư quán", status, DateTime.Now);
            LSHoatDongBUS lichSuHD_BUS = new LSHoatDongBUS();
            lichSuHD_BUS.InsertLSHoatDong(lichSuHD);
        }

        private void onInput(object sender, EventArgs e)
        {
            enterMTV.Text = "";
            enterMTV.ForeColor = Color.Black;
        }

        private void checkEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void KiemTra_Load(object sender, EventArgs e)
        {

        }
    }
}
