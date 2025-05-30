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
    public partial class Vipham : UserControl
    {
        private ViPhamBUS viPhamBUS = new ViPhamBUS();

        public Vipham()
        {
            InitializeComponent();


            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = viPhamBUS.GetAllViPham();
            dataGridView1.DataSource = dt;
        }

        private void onClick(object sender, MouseEventArgs e)
        {
            Themvipham addViPhamForm = new Themvipham();
            addViPhamForm.ShowDialog();
            LoadData();
        }

        private void XulyBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Lấy dòng đầu tiên được chọn
                                                                             // Bạn có thể lấy dữ liệu từ dòng nếu cần, ví dụ:
                                                                             // string maViPham = selectedRow.Cells["ma_vipham"].Value.ToString();
                if (selectedRow.Cells["Trangthai"].Value.ToString() == "Da xu ly")
                {
                    MessageBox.Show("Vi phạm này đã được xử lý. Vui lòng chọn vi phạm khác");
                    return;
                }
                string[] data = new string[6];
                data[0] = selectedRow.Cells["thanhvien"].Value.ToString();
                data[1] = selectedRow.Cells["tenvipham"].Value.ToString();
                data[2] = selectedRow.Cells["mota"].Value.ToString();
                data[3] = selectedRow.Cells["trangthai"].Value.ToString();
                data[4] = selectedRow.Cells["ID"].Value.ToString();
                data[5] = selectedRow.Cells["Mathanhvien"].Value.ToString();

                Xulyvipham xulyViPhamForm = new Xulyvipham(data);
                xulyViPhamForm.ShowDialog();
                LoadData(); // Tải lại dữ liệu sau khi xử lý
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xử lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
