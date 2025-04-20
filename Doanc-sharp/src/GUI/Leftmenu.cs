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
    public partial class Leftmenu : UserControl
    {
        public Leftmenu()
        {
            InitializeComponent();
        }
        public event EventHandler<string> ButtonClicked;
        private void btn_datcho_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "datcho");
        }

        private void btn_baotri_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "baotri");
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "check");
        }

        private void btn_thanhvien_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "thanhvien");
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "nhanvien");
        }

        private void btn_thietbi_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "thietbi");
        }

        private void btn_ban_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "ban");
        }

        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "danhmuc");

        }

        private void btn_vipham_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "vipham");
        }

        private void btn_lshoatdong_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "lshd");
        }

        private void btn_baocao_thongke_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "baocao");
        }
    }
}
