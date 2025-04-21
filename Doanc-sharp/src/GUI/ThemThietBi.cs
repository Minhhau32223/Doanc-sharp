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
    public partial class ThemThietBi : Form
    {
        public ThemThietBi()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ThietBiDTO tb = new ThietBiDTO
            {
                Tenthietbi = txtDeviceName.Text,
                Madanhmuc = txtDeviceID.Text,
                Trangthai = txtStatus.Text,
                Giathue = int.Parse(txtRentPrice.Text)
            };

            ThietBiBUS bus = new ThietBiBUS();
            if (bus.ThemThietBi(tb))
            {
                MessageBox.Show("Thêm thiết bị thành công!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}
