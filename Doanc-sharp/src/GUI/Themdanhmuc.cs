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

namespace Doanc_sharp
{
    public partial class Themdanhmuc : Form
    {
        private DanhMucBUS DanhMucBus;
        public Themdanhmuc()
        {
            InitializeComponent();
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XacnhanBtn_Click(object sender, EventArgs e)
        {
            DanhMucDTO dm = new DanhMucDTO();
            dm.Tendanhmuc = TenTbx.Text;
            dm.Danhmuc = MotaTbx.Text;

            DanhMucBus = new DanhMucBUS();
            Boolean temp = DanhMucBus.ThemDanhMuc(dm);
            if (temp)
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}