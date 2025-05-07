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
    public partial class Suadanhmuc : Form
    {
        private string MaDM;

        private DanhMucBUS DanhMucBus;
        public Suadanhmuc(DataGridViewRow row)
        {
            InitializeComponent();
            TenTbx.Text = row.Cells["Tendanhmuc"].Value?.ToString();
            MotaTbx.Text = row.Cells["Mota"].Value ? .ToString();
            MaDM = row.Cells["ID"].Value ? .ToString();
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XacnhanBtn_Click(object sender, EventArgs e)
        {
            DanhMucDTO dm = new DanhMucDTO();
            dm.Madanhmuc = MaDM;
            dm.Tendanhmuc = TenTbx.Text;
            dm.Danhmuc = MotaTbx.Text;

            MessageBox.Show(dm.Madanhmuc);
            DanhMucBus = new DanhMucBUS();
            Boolean temp = DanhMucBus.SuaDanhMuc(dm);

            if (temp)
            {
                MessageBox.Show("Sửa thành công");

                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
    }
}
