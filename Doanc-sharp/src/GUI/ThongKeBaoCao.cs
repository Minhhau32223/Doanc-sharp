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
namespace Doanc_sharp
{
    public partial class ThongKeBaoCao : UserControl
    {
        private LSHoatDongBUS lsHoatDongBus = new LSHoatDongBUS();
        private PhieuMuonBUS phieuMuonBus = new PhieuMuonBUS();
        private ViPhamBUS viPhamBUS = new ViPhamBUS();
        public ThongKeBaoCao()
        {
            InitializeComponent();
        }

        public void LoadDataTabLuotVao(DateTime tuNgay, DateTime denNgay)
        {
            var data = lsHoatDongBus.layDuLieuLuotVao(tuNgay, denNgay);
            tblLuotVao.Rows.Clear();
            int tongSoLuotVao = 0;
            foreach (var item in data)
            {
                tblLuotVao.Rows.Add(item.Item1, item.Item2, item.Item3, item.Item4, item.Item5, item.Item6);
                tongSoLuotVao += item.Item6;
            }
            lblTongSoLuong.Text = "Tổng lượt vào: " + tongSoLuotVao.ToString();
        }

        public void LoadDataTabThietBiDuocMuon(DateTime tuNgay, DateTime denNgay, string tuKhoa)
        {
            DataTable dt = phieuMuonBus.layDuLieuThietBiDuocMuon(tuNgay, denNgay, tuKhoa);
            tblTBDuocMuon.DataSource = dt;
        }

        public void LoadDataTabThietBiDangDuocMuon(DateTime tuNgay, DateTime denNgay, string tuKhoa)
        {
            DataTable dt = phieuMuonBus.layDuLieuThietBiDangDuocMuon(tuNgay, denNgay, tuKhoa);
            tblTBDangDuocMuon.DataSource = dt;
        }

        public void LoadDataTabViPham()
        {
            DataTable dt = viPhamBUS.GetAllViPham();
            tblViPham.DataSource = dt;
        }

        private void cmbNgayTuanThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = tuNgayLuotVao.Value.Date;
            DateTime denNgay = denNgayLuotVao.Value.Date;
            LoadDataTabLuotVao(tuNgay, denNgay);
        }

        private void ThongKeBaoCao_Load(object sender, EventArgs e)
        {
            // tab1
            DateTime tuNgay1 = tuNgayLuotVao.Value.Date;
            DateTime denNgay1 = denNgayLuotVao.Value.Date;
            LoadDataTabLuotVao(tuNgay1, denNgay1);

            // tab2
            DateTime tuNgay2 = tuNgayTBDuocMuon.Value.Date;
            DateTime denNgay2 = denNgayTBDuocMuon.Value.Date;
            string tuKhoa2 = txtTenTBDuocMuon.Text;
            LoadDataTabThietBiDuocMuon(tuNgay2, denNgay2, tuKhoa2);

            //tab3
            DateTime tuNgay = tuNgayTBDangDuocMuon.Value.Date;
            DateTime denNgay = denNgayTBDangDuocMuon.Value.Date;
            string tuKhoa = txtTenTBDuocMuon.Text;
            LoadDataTabThietBiDangDuocMuon(tuNgay, denNgay, tuKhoa);

            //tab4
            LoadDataTabViPham();
        }

        private void tuNgayLuotVao_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = tuNgayLuotVao.Value.Date;
            DateTime denNgay = denNgayLuotVao.Value.Date;
            LoadDataTabLuotVao(tuNgay, denNgay);
        }


        private void tuNgayTBDuocMuon_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = tuNgayTBDuocMuon.Value.Date;
            DateTime denNgay = denNgayTBDuocMuon.Value.Date;
            string tuKhoa = txtTenTBDuocMuon.Text;
            LoadDataTabThietBiDuocMuon(tuNgay, denNgay, tuKhoa);

        }

        private void denNgayTBDuocMuon_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = tuNgayTBDuocMuon.Value.Date;
            DateTime denNgay = denNgayTBDuocMuon.Value.Date;
            string tuKhoa = txtTenTBDuocMuon.Text;
            LoadDataTabThietBiDuocMuon(tuNgay, denNgay, tuKhoa);
        }

        private void txtTenTBDuocMuon_TextChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = tuNgayTBDuocMuon.Value.Date;
            DateTime denNgay = denNgayTBDuocMuon.Value.Date;
            string tuKhoa = txtTenTBDuocMuon.Text;
            LoadDataTabThietBiDuocMuon(tuNgay, denNgay, tuKhoa);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = tuNgayTBDangDuocMuon.Value.Date;
            DateTime denNgay = denNgayTBDangDuocMuon.Value.Date;
            string tuKhoa = txtTenTBDuocMuon.Text;
            LoadDataTabThietBiDangDuocMuon(tuNgay, denNgay, tuKhoa);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = tuNgayTBDangDuocMuon.Value.Date;
            DateTime denNgay = denNgayTBDangDuocMuon.Value.Date;
            string tuKhoa = txtTenTBDuocMuon.Text;
            LoadDataTabThietBiDangDuocMuon(tuNgay, denNgay, tuKhoa);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = tuNgayTBDangDuocMuon.Value.Date;
            DateTime denNgay = denNgayTBDangDuocMuon.Value.Date;
            string tuKhoa = txtTenTBDuocMuon.Text;
            LoadDataTabThietBiDangDuocMuon(tuNgay, denNgay, tuKhoa);
        }

        

        private void cmbViPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = viPhamBUS.GetAllViPham();
            string selectedValue = cmbViPham.SelectedItem.ToString();

            if (selectedValue == "Tất cả vi phạm")
            {
                tblViPham.DataSource = dt;
                return;
            }
            else if (selectedValue == "Chưa xử lý")
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = $"Trangthai LIKE '%Chua xu ly%'";
                tblViPham.DataSource = dv;
            }
            else
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = $"Trangthai LIKE '%Da xu ly%'";
                tblViPham.DataSource = dv;
            }

        }

        private void tblViPham_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.ToolTipText = tblViPham.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }
        private void tblTBDuocMuon_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.ToolTipText = tblTBDuocMuon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }

        private void tblTBDangDuocMuon_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.ToolTipText = tblTBDangDuocMuon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }


        private void tblLuotVao_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.ToolTipText = tblLuotVao.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }
    }
}
