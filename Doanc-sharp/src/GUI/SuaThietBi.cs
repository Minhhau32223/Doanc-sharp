﻿using System;
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

    public partial class SuaThietBi : Form
    {
        private ThietBiDTO thietbi;
        public SuaThietBi(ThietBiDTO tb)
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn đã chắc chắn xác nhận  không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                return;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
