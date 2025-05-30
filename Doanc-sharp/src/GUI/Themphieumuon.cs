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
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;

namespace Doanc_sharp
{
    public partial class Themphieumuon : Form
    {
        private Tools tools = new Tools();
        private ThietBiBUS tbbus;
        private PhieuMuonBUS phieuMuonbus;
        private CtPhieuMuonBUS ctPhieuMuonbus;
        private LSHoatDongBUS lshdBUS;
        private ThanhVienBUS tvbus;
        public Themphieumuon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                return;
            }
            else
            { return;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CbbTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbTrangthai.SelectedItem == "Đã trả")
            {
                textNgaytra.Text = DateTime.Now.ToString();
            }
            else
            {
                textNgaytra.Text = DateTime.Now.AddDays(3).ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string ngaymuon = textBoxsongaymuon.Text.Trim();
          

            if (string.IsNullOrEmpty(ngaymuon))
            {
                textNgaytra.Text = DateTime.Now.ToString();
                return;
            }

            if (!tools.IsPositiveInteger(ngaymuon))
            {
                MessageBox.Show("Vui lòng nhập số ngày mượn là số dương!");
                return;
            }

            int songay = Convert.ToInt32(ngaymuon);
            textNgaytra.Text = DateTime.Now.AddDays(songay).ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!tools.IsNotEmpty(txtMatb.Text, "Mã thiết bị") || !tools.IsNotEmpty(txtSoluong.Text, "Số luọng"))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã thiết bị và số lượng!");
                return;
            }

            if (!tools.IsPositiveInteger(txtMatb.Text) || !tools.IsPositiveInteger(txtSoluong.Text))
            {
                MessageBox.Show("Mã thiết bị và số lượng phải là số nguyên dương!");
                return;
            }

            int matb = Convert.ToInt32(txtMatb.Text);
            int soluong = Convert.ToInt32(txtSoluong.Text);

            tbbus = new ThietBiBUS();
            DataTable dt = tbbus.Timkiemtheoma(matb);

            foreach (DataRow dr in dt.Rows) {
                ThietBiDTO thietbitemp = new ThietBiDTO
                {
                    Mathietbi = Convert.ToInt32(dr["Mathietbi"]),
                    Tenthietbi = dr["Tenthietbi"].ToString(),
                    Madanhmuc = dr["Madanhmuc"].ToString(),
                    Giathue = Convert.ToInt32(dr["Giathue"]),
                    Trangthai = dr["Trangthai"].ToString(),
                };
                if(!thietbitemp.Trangthai.ToString().Contains("Đang trống"))
                {
                    MessageBox.Show("Thiết bị đang cho thuê vui lòng chọn thiết bị khác");
                    return;
                }    
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow newRow = dt.Rows[0];
                bool found = false;
              

                foreach (DataGridViewRow row in Datatbmuon.Rows)
                {
                    if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == matb)
                    {
                        // Đã có mã thiết bị, cộng thêm số lượng
                        int currentSoluong = Convert.ToInt32(row.Cells[2].Value);
                        row.Cells[2].Value = currentSoluong + soluong;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    // Nếu chưa có thì thêm dòng mới
                    int rowIndex = Datatbmuon.Rows.Add();
                    Datatbmuon.Rows[rowIndex].Cells[0].Value = newRow["Mathietbi"];
                    Datatbmuon.Rows[rowIndex].Cells[1].Value = newRow["Tenthietbi"];
                    Datatbmuon.Rows[rowIndex].Cells[2].Value = soluong;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thiết bị với mã đã nhập!");
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Themphieumuon_Load(object sender, EventArgs e)
        {

        }
        public void loadaddpm()
        {
            int mapm = tools.GenerateUniqueNumber("phieumuon", "Maphieumuon");
            textBoxMaphieumuon.Text = Convert.ToString(mapm);
            textBoxMaphieumuon.ReadOnly = true;
            txtNgayMuon.Text = DateTime.Now.ToString();
            textNgaytra.Text = DateTime.Now.AddDays(3).ToString();
            txtNgayMuon.ReadOnly = true;
            if (CbbTrangthai.Items.Count == 0)
            {
                CbbTrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
                CbbTrangthai.Items.Clear();
                CbbTrangthai.Items.Add("Đang mượn");
                CbbTrangthai.Items.Add("Đã trả");

            }
            CbbTrangthai.SelectedItem = "Đang mượn";
            txtSoluong.Text = "1";
            txtSoluong.ReadOnly = true;

        }
        public void loadUpdate(int mapm, DateTime ngaymuon, DateTime ngaytra, string trangthai, int mathanhvien, string label)
        { this.labelTitle.Text = label;
            tbbus = new ThietBiBUS();
            phieuMuonbus = new PhieuMuonBUS();
            ctPhieuMuonbus = new CtPhieuMuonBUS();
            textBoxMaphieumuon.Text = mapm.ToString();
            txtMathanhvien.Text = mathanhvien.ToString();
            Datatbmuon.DataSource = ctPhieuMuonbus.LayDanhSachChiTiet(mapm);
            txtNgayMuon.Text = ngaymuon.ToString();
            textNgaytra.Text = DateTime.Now.ToString();
            textBoxMaphieumuon.ReadOnly = true;
            txtMathanhvien.ReadOnly = true;
            textBoxMaphieumuon.ReadOnly = true;
            CbbTrangthai.DropDownStyle = ComboBoxStyle.DropDownList;

            // Xóa và thêm lại danh sách mỗi lần (tránh tình trạng chỉ có 1 mục do đã thêm trước đó)
            CbbTrangthai.Items.Clear();
            CbbTrangthai.Items.Add("Đã trả");
            if (!string.IsNullOrWhiteSpace(trangthai))
            {
                CbbTrangthai.SelectedItem = "Đã trả";
            }
            else
            {
                CbbTrangthai.SelectedIndex = 0; // hoặc -1 nếu không muốn chọn sẵn
            }


            CbbTrangthai.Enabled = false;
            txtMatb.Visible = false;
            txtSoluong.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            Btnbo.Visible = false;
            btnThem.Visible = false;
            label1.Visible = false;
            textBoxsongaymuon.Visible = false;
            textBoxsongaymuon.Enabled = false;

            txtNgayMuon.ReadOnly = true;
            BtnXacnhan.Text = "Xác nhận trả";
        }

        private void Btnbo_Click(object sender, EventArgs e)
        {
            if (Datatbmuon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in Datatbmuon.SelectedRows)
                {
                    if (!row.IsNewRow) // Không xóa dòng mới đang nhập
                    {
                        Datatbmuon.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnXacnhan_Click(object sender, EventArgs e)
        {



            // Kiểm tra dữ liệu nhập
            if (!tools.IsNotEmpty(textBoxMaphieumuon.Text, "Mã phiếu mượn") ||
                !tools.IsNotEmpty(txtMathanhvien.Text, "Mã thành viên") ||
                !tools.IsNotEmpty(txtNgayMuon.Text, "Ngày mượn") ||
                !tools.IsNotEmpty(textNgaytra.Text, "Ngày trả") ||
                CbbTrangthai.SelectedItem == null)
            {
                return;
            }

            DateTime nm, ntr;
            try
            {
                nm = Convert.ToDateTime(txtNgayMuon.Text);
                ntr = Convert.ToDateTime(textNgaytra.Text);
            }
            catch
            {
                MessageBox.Show("Ngày mượn hoặc ngày trả không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DialogResult result = MessageBox.Show("Bạn đã chắc chắn xác nhận  không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (CbbTrangthai.SelectedItem == "Đang mượn")
                {
                    phieuMuonbus = new PhieuMuonBUS();
                    ctPhieuMuonbus = new CtPhieuMuonBUS();
                    lshdBUS = new LSHoatDongBUS();
                    tbbus = new ThietBiBUS();
                    tvbus = new ThanhVienBUS();
                    
                    int maphieumuon = Convert.ToInt32(textBoxMaphieumuon.Text);
                    int matv = Convert.ToInt32(txtMathanhvien.Text);
                    ThanhVienDTO temptv = tvbus.TimThanhVienTheoMa(matv);
                    if(temptv ==null)
                    {
                        MessageBox.Show("Mã thành viên không  tồn tại!!");
                        return;
                    }    

                    string trangthai = CbbTrangthai.SelectedItem.ToString();


                    phieuMuonbus.ThemPhieuMuon(new PhieuMuonDTO(maphieumuon, nm, ntr, trangthai, matv));

                    foreach (DataGridViewRow row in Datatbmuon.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int mathietbi = Convert.ToInt32(row.Cells["Mathietbi"].Value.ToString());
                            int soluong = Convert.ToInt32(row.Cells["Soluong"].Value.ToString());
                            DataTable dt = tbbus.Timkiemtheoma(mathietbi);
                            ThietBiDTO tbtemp = null;
                            foreach (DataRow rowtb in dt.Rows)
                            {
                                tbtemp = new ThietBiDTO
                                {
                                    Mathietbi = Convert.ToInt32(rowtb["Mathietbi"]),
                                    Tenthietbi = rowtb["Tenthietbi"].ToString(),
                                    Madanhmuc = rowtb["Madanhmuc"].ToString(),
                                    Giathue = Convert.ToInt32(rowtb["Giathue"]),
                                    Trangthai = rowtb["Trangthai"].ToString(),
                                };
                            }
                            tbtemp.Trangthai = "Đang thuê";
                            tbbus.CapNhatThietBi(tbtemp);
                            ChiTietPhieuMuonDTO temp = new ChiTietPhieuMuonDTO(maphieumuon, mathietbi, soluong);
                            ctPhieuMuonbus.ThemChiTiet(temp);
                        }
                    }

                    LSHoatDongDTO templshd = new LSHoatDongDTO(matv, tools.GenerateUniqueNumber("lichsuhoatdong", "Mahoatdong"), "Mượn thiết bị ", "Mượn thành công", DateTime.Now);
                    lshdBUS.InsertLSHoatDong(templshd);

                    MessageBox.Show("Thêm phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    phieuMuonbus = new PhieuMuonBUS();
                    ctPhieuMuonbus = new CtPhieuMuonBUS();
                    lshdBUS = new LSHoatDongBUS();
                    tbbus = new ThietBiBUS();

                    int maphieumuon = Convert.ToInt32(textBoxMaphieumuon.Text);
                    int matv = Convert.ToInt32(txtMathanhvien.Text);
                    string trangthai = CbbTrangthai.SelectedItem.ToString();
                    phieuMuonbus.CapNhatPhieuMuon(new PhieuMuonDTO(maphieumuon, nm, ntr, trangthai, matv));
                    foreach (DataGridViewRow row in Datatbmuon.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int mathietbi = Convert.ToInt32(row.Cells["Mathietbi"].Value.ToString());

                            DataTable dt = tbbus.Timkiemtheoma(mathietbi);
                            ThietBiDTO tbtemp = null;
                            foreach (DataRow rowtb in dt.Rows)
                            {
                                tbtemp = new ThietBiDTO
                                {
                                    Mathietbi = Convert.ToInt32(rowtb["Mathietbi"]),
                                    Tenthietbi = rowtb["Tenthietbi"].ToString(),
                                    Madanhmuc = rowtb["Madanhmuc"].ToString(),
                                    Giathue = Convert.ToInt32(rowtb["Giathue"]),
                                    Trangthai = rowtb["Trangthai"].ToString(),
                                };
                            }
                            tbtemp.Trangthai = "Đang trống";
                            tbbus.CapNhatThietBi(tbtemp);

                        }
                     }
                        MessageBox.Show("Xác nhận trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LSHoatDongDTO templshd = new LSHoatDongDTO(matv, tools.GenerateUniqueNumber("lichsuhoatdong", "Mahoatdong"), "Trả thiết bị ", "Trả thành công", DateTime.Now);
                        lshdBUS.InsertLSHoatDong(templshd);
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Hủy thao tác thêm phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }



            }
        }
}

