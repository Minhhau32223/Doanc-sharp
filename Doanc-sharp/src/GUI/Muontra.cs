using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doanc_sharp.src.BUS;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;

namespace Doanc_sharp
{
    public partial class Muontra : UserControl
    {
        private PhieuMuonBUS pmbus;
        private CtPhieuMuonBUS ctBus;
        private Tools tools = new Tools();
        public Muontra()
        {
            InitializeComponent();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Themphieumuon themphieumuon = new Themphieumuon();

            themphieumuon.loadaddpm();

            themphieumuon.ShowDialog();
        }

        private void Muontra_Load(object sender, EventArgs e)
        {

        }
        public void loadData()
        {

            pmbus = new PhieuMuonBUS();
            DataMuon.DataSource = pmbus.LayDanhSachPhieuMuon();
            dataTra.DataSource = pmbus.LayDanhSachPhieuTra();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataMuon.CurrentRow != null)
            {
                string maphieumuon = Convert.ToString(DataMuon.CurrentRow.Cells["Maphieumuon"].Value.ToString());
                string mathanhvien = Convert.ToString(DataMuon.CurrentRow.Cells["Mathanhvien"].Value.ToString());
                string ngaymuon = Convert.ToString(DataMuon.CurrentRow.Cells["Ngaymuon"].Value.ToString());
                string ngaytra = Convert.ToString(DataMuon.CurrentRow.Cells["Ngaytra"].Value.ToString());
                string trangthai = Convert.ToString(DataMuon.CurrentRow.Cells["Trangthai"].Value.ToString());
                Xemchitietmuon xct = new Xemchitietmuon();
                xct.loadct(maphieumuon, mathanhvien, ngaymuon, ngaytra, trangthai);
                xct.view();
                xct.ShowDialog();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (DataMuon.CurrentRow != null)
            {
                int mapm = Convert.ToInt32(DataMuon.CurrentRow.Cells["Maphieumuon"].Value.ToString());
                int matv = Convert.ToInt32(DataMuon.CurrentRow.Cells["Mathanhvien"].Value.ToString());
                DateTime nm = Convert.ToDateTime(DataMuon.CurrentRow.Cells["Ngaymuon"].Value.ToString());
                DateTime ntr = Convert.ToDateTime(DataMuon.CurrentRow.Cells["Ngaytra"].Value.ToString());
                string trangthai = DataMuon.CurrentRow.Cells["Trangthai"].Value.ToString();
                Themphieumuon tpm = new Themphieumuon();
                tpm.loadUpdate(mapm, nm, ntr, trangthai, matv, "Cập nhật phiếu mượn");

                tpm.ShowDialog();


            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DataMuon.SelectedRows.Count > 0)
            {
                int maphieumuon = Convert.ToInt32(DataMuon.SelectedRows[0].Cells["Maphieumuon"].Value.ToString());

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu mượn có mã {maphieumuon}?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Gọi BUS để xóa chi tiết phiếu mượn trước
                    ctBus = new CtPhieuMuonBUS();

                    ctBus.XoaChiTiet(maphieumuon);
                    // Sau đó xóa phiếu mượn
                    PhieuMuonBUS pmBus = new PhieuMuonBUS();
                    pmBus.XoaPhieuMuon(maphieumuon);

                    MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại giao diện
                    loadData(); // Bạn tự định nghĩa lại phương thức này để load lại dữ liệu
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataTra.CurrentRow != null)
            {
                string maphieumuon = Convert.ToString(dataTra.CurrentRow.Cells["Maphieumuon1"].Value.ToString());
                string mathanhvien = Convert.ToString(dataTra.CurrentRow.Cells["Mathanhvien1"].Value.ToString());
                string ngaymuon = Convert.ToString(dataTra.CurrentRow.Cells["Ngaymuon1"].Value.ToString());
                string ngaytra = Convert.ToString(dataTra.CurrentRow.Cells["Ngaytra1"].Value.ToString());
                string trangthai = Convert.ToString(dataTra.CurrentRow.Cells["Trangthai1"].Value.ToString());
                Xemchitietmuon xct = new Xemchitietmuon();
                xct.loadct(maphieumuon, mathanhvien, ngaymuon, ngaytra, trangthai);
                xct.view();
                xct.ShowDialog();
            }
        }

        private void TextBoxTimkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = TextBoxTimkiem.Text.Trim().ToLower();

            // Lấy toàn bộ danh sách gốc
            List<PhieuMuonDTO> danhSachGoc = pmbus.LayDanhSachPhieuMuon();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu không có từ khóa, hiển thị toàn bộ
                DataMuon.DataSource = danhSachGoc;
            }
            else
            {
                // Lọc theo Maphieumuon, Mathanhvien, hoặc Trangthai (tuỳ bạn thêm cột nào)
                var danhSachLoc = danhSachGoc.Where(pm =>
                    pm.Maphieumuon.ToString().Contains(keyword) ||
                    pm.Mathanhvien.ToString().Contains(keyword) ||
                    (!string.IsNullOrEmpty(pm.Trangthai) && pm.Trangthai.ToLower().Contains(keyword))
                ).ToList();

                DataMuon.DataSource = danhSachLoc;
            }
        }
    }
}
