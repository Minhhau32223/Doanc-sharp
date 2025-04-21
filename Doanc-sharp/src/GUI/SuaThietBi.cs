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
<<<<<<< HEAD
    public partial class chitietphieumuon : Form
    {
        public chitietphieumuon()
=======

    public partial class SuaThietBi : Form
    {
        private ThietBiDTO thietbi;
        public SuaThietBi(ThietBiDTO tb)
>>>>>>> 40df31548af632b16847f172cd5133b0c4335b1d
        {
            InitializeComponent();
            thietbi = tb;

            txtDeviceID.Text = thietbi.Madanhmuc;
            txtDeviceName.Text = thietbi.Tenthietbi;
            txtRentPrize.Text = thietbi.Giathue.ToString();
            txtStatus.Text = thietbi.Trangthai;
        }

        private void SuaThietBi_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void label1_Click(object sender, EventArgs e)
        {

=======
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            thietbi.Madanhmuc = txtDeviceID.Text;
            thietbi.Tenthietbi = txtDeviceName.Text;
            thietbi.Giathue = int.Parse(txtRentPrize.Text);
            thietbi.Trangthai = txtStatus.Text;

            ThietBiBUS bus = new ThietBiBUS();
            if (bus.CapNhatThietBi(thietbi))
            {
                MessageBox.Show("Cập nhật thành công!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
>>>>>>> 40df31548af632b16847f172cd5133b0c4335b1d
        }
    }
}
