namespace Doanc_sharp
{
    partial class ThongKeBaoCao
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tab = new TabControl();
            tabLuotVao = new TabPage();
            tblLuotVao = new DataGridView();
            MaThanhVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            lblTongSoLuong = new Label();
            lblDenNgay = new Label();
            lblTuNgay = new Label();
            denNgayLuotVao = new DateTimePicker();
            tuNgayLuotVao = new DateTimePicker();
            tabTBDuocMuon = new TabPage();
            label7 = new Label();
            tblTBDuocMuon = new DataGridView();
            tab2HoTen = new DataGridViewTextBoxColumn();
            tab2TenThietBi = new DataGridViewTextBoxColumn();
            tab2NgayMuon = new DataGridViewTextBoxColumn();
            tab2NgayTra = new DataGridViewTextBoxColumn();
            tab2TrangThai = new DataGridViewTextBoxColumn();
            tab2SoLuong = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtTenTBDuocMuon = new TextBox();
            denNgayTBDuocMuon = new DateTimePicker();
            tuNgayTBDuocMuon = new DateTimePicker();
            tabTBDangDuocMuon = new TabPage();
            label8 = new Label();
            tblTBDangDuocMuon = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            txtTenTBDangDuocMuon = new TextBox();
            label3 = new Label();
            label4 = new Label();
            denNgayTBDangDuocMuon = new DateTimePicker();
            tuNgayTBDangDuocMuon = new DateTimePicker();
            tabViPham = new TabPage();
            cmbViPham = new ComboBox();
            tblViPham = new DataGridView();
            tab4MaViPham = new DataGridViewTextBoxColumn();
            tab4HoTen = new DataGridViewTextBoxColumn();
            tab4TenViPham = new DataGridViewTextBoxColumn();
            tab4MoTa = new DataGridViewTextBoxColumn();
            tab4NgayVP = new DataGridViewTextBoxColumn();
            tab4TrangThai = new DataGridViewTextBoxColumn();
            lblThongKe = new Label();
            tab.SuspendLayout();
            tabLuotVao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblLuotVao).BeginInit();
            tabTBDuocMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblTBDuocMuon).BeginInit();
            tabTBDangDuocMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblTBDangDuocMuon).BeginInit();
            tabViPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblViPham).BeginInit();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(tabLuotVao);
            tab.Controls.Add(tabTBDuocMuon);
            tab.Controls.Add(tabTBDangDuocMuon);
            tab.Controls.Add(tabViPham);
            tab.Location = new Point(3, 43);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(939, 629);
            tab.TabIndex = 0;
            // 
            // tabLuotVao
            // 
            tabLuotVao.Controls.Add(tblLuotVao);
            tabLuotVao.Controls.Add(lblTongSoLuong);
            tabLuotVao.Controls.Add(lblDenNgay);
            tabLuotVao.Controls.Add(lblTuNgay);
            tabLuotVao.Controls.Add(denNgayLuotVao);
            tabLuotVao.Controls.Add(tuNgayLuotVao);
            tabLuotVao.Location = new Point(4, 24);
            tabLuotVao.Name = "tabLuotVao";
            tabLuotVao.Padding = new Padding(3);
            tabLuotVao.Size = new Size(931, 601);
            tabLuotVao.TabIndex = 0;
            tabLuotVao.Text = "Lượt vào";
            tabLuotVao.UseVisualStyleBackColor = true;
            // 
            // tblLuotVao
            // 
            tblLuotVao.AllowUserToAddRows = false;
            tblLuotVao.AllowUserToDeleteRows = false;
            tblLuotVao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblLuotVao.Columns.AddRange(new DataGridViewColumn[] { MaThanhVien, HoTen, Loai, ChiTiet, ThoiGian, SoLuong });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tblLuotVao.DefaultCellStyle = dataGridViewCellStyle1;
            tblLuotVao.Location = new Point(33, 94);
            tblLuotVao.Name = "tblLuotVao";
            tblLuotVao.ReadOnly = true;
            tblLuotVao.Size = new Size(866, 452);
            tblLuotVao.TabIndex = 7;
            tblLuotVao.CellToolTipTextNeeded += tblLuotVao_CellToolTipTextNeeded;
            // 
            // MaThanhVien
            // 
            MaThanhVien.DataPropertyName = "Mathanhvien";
            MaThanhVien.HeaderText = "Mã thành viên";
            MaThanhVien.Name = "MaThanhVien";
            MaThanhVien.ReadOnly = true;
            MaThanhVien.Width = 137;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "Hoten";
            HoTen.HeaderText = "Họ tên";
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 137;
            // 
            // Loai
            // 
            Loai.DataPropertyName = "Loai";
            Loai.HeaderText = "Loại hoạt động";
            Loai.Name = "Loai";
            Loai.ReadOnly = true;
            Loai.Width = 138;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "Chitiet";
            ChiTiet.HeaderText = "Chi tiết hoạt động";
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            ChiTiet.Width = 137;
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "Thoigian";
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.Name = "ThoiGian";
            ThoiGian.ReadOnly = true;
            ThoiGian.Width = 137;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượt vào";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Width = 137;
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.AutoSize = true;
            lblTongSoLuong.Font = new Font("Segoe UI", 12F);
            lblTongSoLuong.Location = new Point(41, 29);
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(117, 21);
            lblTongSoLuong.TabIndex = 6;
            lblTongSoLuong.Text = "Tổng số lượng: ";
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(663, 32);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(28, 15);
            lblDenNgay.TabIndex = 4;
            lblDenNgay.Text = "Đến";
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(409, 32);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(21, 15);
            lblTuNgay.TabIndex = 3;
            lblTuNgay.Text = "Từ";
            // 
            // denNgayLuotVao
            // 
            denNgayLuotVao.Location = new Point(699, 29);
            denNgayLuotVao.Name = "denNgayLuotVao";
            denNgayLuotVao.Size = new Size(200, 23);
            denNgayLuotVao.TabIndex = 1;
            denNgayLuotVao.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // tuNgayLuotVao
            // 
            tuNgayLuotVao.Location = new Point(445, 29);
            tuNgayLuotVao.Name = "tuNgayLuotVao";
            tuNgayLuotVao.Size = new Size(200, 23);
            tuNgayLuotVao.TabIndex = 0;
            tuNgayLuotVao.ValueChanged += tuNgayLuotVao_ValueChanged;
            // 
            // tabTBDuocMuon
            // 
            tabTBDuocMuon.Controls.Add(label7);
            tabTBDuocMuon.Controls.Add(tblTBDuocMuon);
            tabTBDuocMuon.Controls.Add(label1);
            tabTBDuocMuon.Controls.Add(label2);
            tabTBDuocMuon.Controls.Add(txtTenTBDuocMuon);
            tabTBDuocMuon.Controls.Add(denNgayTBDuocMuon);
            tabTBDuocMuon.Controls.Add(tuNgayTBDuocMuon);
            tabTBDuocMuon.Location = new Point(4, 24);
            tabTBDuocMuon.Name = "tabTBDuocMuon";
            tabTBDuocMuon.Padding = new Padding(3);
            tabTBDuocMuon.Size = new Size(931, 601);
            tabTBDuocMuon.TabIndex = 1;
            tabTBDuocMuon.Text = "Thiết bị được mượn";
            tabTBDuocMuon.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 27);
            label7.Name = "label7";
            label7.Size = new Size(147, 15);
            label7.TabIndex = 12;
            label7.Text = "Tìm kiếm bằng tên thiết bị";
            // 
            // tblTBDuocMuon
            // 
            tblTBDuocMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblTBDuocMuon.Columns.AddRange(new DataGridViewColumn[] { tab2HoTen, tab2TenThietBi, tab2NgayMuon, tab2NgayTra, tab2TrangThai, tab2SoLuong });
            tblTBDuocMuon.Location = new Point(44, 96);
            tblTBDuocMuon.Name = "tblTBDuocMuon";
            tblTBDuocMuon.Size = new Size(854, 471);
            tblTBDuocMuon.TabIndex = 11;
            tblTBDuocMuon.CellToolTipTextNeeded += tblTBDuocMuon_CellToolTipTextNeeded;
            // 
            // tab2HoTen
            // 
            tab2HoTen.DataPropertyName = "Hoten";
            tab2HoTen.HeaderText = "Họ tên";
            tab2HoTen.Name = "tab2HoTen";
            tab2HoTen.Width = 150;
            // 
            // tab2TenThietBi
            // 
            tab2TenThietBi.DataPropertyName = "Tenthietbi";
            tab2TenThietBi.HeaderText = "Tên thiết bị";
            tab2TenThietBi.Name = "tab2TenThietBi";
            tab2TenThietBi.Width = 150;
            // 
            // tab2NgayMuon
            // 
            tab2NgayMuon.DataPropertyName = "Ngaymuon";
            tab2NgayMuon.HeaderText = "Ngày mượn";
            tab2NgayMuon.Name = "tab2NgayMuon";
            tab2NgayMuon.Width = 150;
            // 
            // tab2NgayTra
            // 
            tab2NgayTra.DataPropertyName = "Ngaytra";
            tab2NgayTra.HeaderText = "Ngày trả";
            tab2NgayTra.Name = "tab2NgayTra";
            tab2NgayTra.Width = 150;
            // 
            // tab2TrangThai
            // 
            tab2TrangThai.DataPropertyName = "Trangthai";
            tab2TrangThai.HeaderText = "Trạng thái";
            tab2TrangThai.Name = "tab2TrangThai";
            tab2TrangThai.Width = 150;
            // 
            // tab2SoLuong
            // 
            tab2SoLuong.DataPropertyName = "Soluong";
            tab2SoLuong.HeaderText = "Số lượng";
            tab2SoLuong.Name = "tab2SoLuong";
            tab2SoLuong.Width = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(682, 37);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 10;
            label1.Text = "Đến";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 37);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 9;
            label2.Text = "Từ";
            // 
            // txtTenTBDuocMuon
            // 
            txtTenTBDuocMuon.Location = new Point(47, 57);
            txtTenTBDuocMuon.Name = "txtTenTBDuocMuon";
            txtTenTBDuocMuon.Size = new Size(367, 23);
            txtTenTBDuocMuon.TabIndex = 8;
            txtTenTBDuocMuon.TextChanged += txtTenTBDuocMuon_TextChanged;
            // 
            // denNgayTBDuocMuon
            // 
            denNgayTBDuocMuon.Location = new Point(718, 34);
            denNgayTBDuocMuon.Name = "denNgayTBDuocMuon";
            denNgayTBDuocMuon.Size = new Size(200, 23);
            denNgayTBDuocMuon.TabIndex = 7;
            denNgayTBDuocMuon.ValueChanged += denNgayTBDuocMuon_ValueChanged;
            // 
            // tuNgayTBDuocMuon
            // 
            tuNgayTBDuocMuon.Location = new Point(464, 34);
            tuNgayTBDuocMuon.Name = "tuNgayTBDuocMuon";
            tuNgayTBDuocMuon.Size = new Size(200, 23);
            tuNgayTBDuocMuon.TabIndex = 6;
            tuNgayTBDuocMuon.ValueChanged += tuNgayTBDuocMuon_ValueChanged;
            // 
            // tabTBDangDuocMuon
            // 
            tabTBDangDuocMuon.Controls.Add(label8);
            tabTBDangDuocMuon.Controls.Add(tblTBDangDuocMuon);
            tabTBDangDuocMuon.Controls.Add(txtTenTBDangDuocMuon);
            tabTBDangDuocMuon.Controls.Add(label3);
            tabTBDangDuocMuon.Controls.Add(label4);
            tabTBDangDuocMuon.Controls.Add(denNgayTBDangDuocMuon);
            tabTBDangDuocMuon.Controls.Add(tuNgayTBDangDuocMuon);
            tabTBDangDuocMuon.Location = new Point(4, 24);
            tabTBDangDuocMuon.Name = "tabTBDangDuocMuon";
            tabTBDangDuocMuon.Padding = new Padding(3);
            tabTBDangDuocMuon.Size = new Size(931, 601);
            tabTBDangDuocMuon.TabIndex = 2;
            tabTBDangDuocMuon.Text = "Thiết bị đang được mượn";
            tabTBDangDuocMuon.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 30);
            label8.Name = "label8";
            label8.Size = new Size(162, 15);
            label8.TabIndex = 15;
            label8.Text = "Tìm kiếm bằng tên sản phẩm";
            // 
            // tblTBDangDuocMuon
            // 
            tblTBDangDuocMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblTBDangDuocMuon.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            tblTBDangDuocMuon.Location = new Point(38, 99);
            tblTBDangDuocMuon.Name = "tblTBDangDuocMuon";
            tblTBDangDuocMuon.Size = new Size(854, 471);
            tblTBDangDuocMuon.TabIndex = 14;
            tblTBDangDuocMuon.CellToolTipTextNeeded += tblTBDangDuocMuon_CellToolTipTextNeeded;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Hoten";
            dataGridViewTextBoxColumn1.HeaderText = "Họ tên";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Tenthietbi";
            dataGridViewTextBoxColumn2.HeaderText = "Tên thiết bị";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Ngaymuon";
            dataGridViewTextBoxColumn3.HeaderText = "Ngày mượn";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Ngaytra";
            dataGridViewTextBoxColumn4.HeaderText = "Ngày trả";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Trangthai";
            dataGridViewTextBoxColumn5.HeaderText = "Trạng thái";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Soluong";
            dataGridViewTextBoxColumn6.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 60;
            // 
            // txtTenTBDangDuocMuon
            // 
            txtTenTBDangDuocMuon.Location = new Point(41, 60);
            txtTenTBDangDuocMuon.Name = "txtTenTBDangDuocMuon";
            txtTenTBDangDuocMuon.Size = new Size(367, 23);
            txtTenTBDangDuocMuon.TabIndex = 13;
            txtTenTBDangDuocMuon.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(682, 37);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 10;
            label3.Text = "Đến";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 37);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 9;
            label4.Text = "Từ";
            // 
            // denNgayTBDangDuocMuon
            // 
            denNgayTBDangDuocMuon.Location = new Point(718, 34);
            denNgayTBDangDuocMuon.Name = "denNgayTBDangDuocMuon";
            denNgayTBDangDuocMuon.Size = new Size(200, 23);
            denNgayTBDangDuocMuon.TabIndex = 7;
            denNgayTBDangDuocMuon.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // tuNgayTBDangDuocMuon
            // 
            tuNgayTBDangDuocMuon.Location = new Point(464, 34);
            tuNgayTBDangDuocMuon.Name = "tuNgayTBDangDuocMuon";
            tuNgayTBDangDuocMuon.Size = new Size(200, 23);
            tuNgayTBDangDuocMuon.TabIndex = 6;
            tuNgayTBDangDuocMuon.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // tabViPham
            // 
            tabViPham.Controls.Add(cmbViPham);
            tabViPham.Controls.Add(tblViPham);
            tabViPham.Location = new Point(4, 24);
            tabViPham.Name = "tabViPham";
            tabViPham.Padding = new Padding(3);
            tabViPham.Size = new Size(931, 601);
            tabViPham.TabIndex = 3;
            tabViPham.Text = "Vi phạm";
            tabViPham.UseVisualStyleBackColor = true;
            // 
            // cmbViPham
            // 
            cmbViPham.FormattingEnabled = true;
            cmbViPham.Items.AddRange(new object[] { "Tất cả vi phạm", "Chưa xử lý", "Đã xử lý" });
            cmbViPham.Location = new Point(777, 23);
            cmbViPham.Name = "cmbViPham";
            cmbViPham.Size = new Size(121, 23);
            cmbViPham.TabIndex = 12;
            cmbViPham.Text = "Tất cả vi phạm";
            cmbViPham.SelectedIndexChanged += cmbViPham_SelectedIndexChanged;
            // 
            // tblViPham
            // 
            tblViPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblViPham.Columns.AddRange(new DataGridViewColumn[] { tab4MaViPham, tab4HoTen, tab4TenViPham, tab4MoTa, tab4NgayVP, tab4TrangThai });
            tblViPham.Location = new Point(31, 70);
            tblViPham.Name = "tblViPham";
            tblViPham.Size = new Size(867, 497);
            tblViPham.TabIndex = 11;
            tblViPham.CellToolTipTextNeeded += tblViPham_CellToolTipTextNeeded;
            // 
            // tab4MaViPham
            // 
            tab4MaViPham.DataPropertyName = "Mavipham";
            tab4MaViPham.HeaderText = "Mã vi phạm";
            tab4MaViPham.Name = "tab4MaViPham";
            tab4MaViPham.Width = 75;
            // 
            // tab4HoTen
            // 
            tab4HoTen.DataPropertyName = "Hoten";
            tab4HoTen.HeaderText = "Họ tên";
            tab4HoTen.Name = "tab4HoTen";
            tab4HoTen.Width = 150;
            // 
            // tab4TenViPham
            // 
            tab4TenViPham.DataPropertyName = "Tenvipham";
            tab4TenViPham.HeaderText = "Tên vi phạm";
            tab4TenViPham.Name = "tab4TenViPham";
            tab4TenViPham.Width = 150;
            // 
            // tab4MoTa
            // 
            tab4MoTa.DataPropertyName = "Mota";
            tab4MoTa.HeaderText = "Mô tả";
            tab4MoTa.Name = "tab4MoTa";
            tab4MoTa.Width = 150;
            // 
            // tab4NgayVP
            // 
            tab4NgayVP.DataPropertyName = "Ngayvp";
            tab4NgayVP.HeaderText = "Ngày vi phạm";
            tab4NgayVP.Name = "tab4NgayVP";
            tab4NgayVP.Width = 150;
            // 
            // tab4TrangThai
            // 
            tab4TrangThai.DataPropertyName = "Trangthai";
            tab4TrangThai.HeaderText = "Trạng thái";
            tab4TrangThai.Name = "tab4TrangThai";
            tab4TrangThai.Width = 150;
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Font = new Font("Segoe UI", 15F);
            lblThongKe.Location = new Point(412, 12);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(107, 28);
            lblThongKe.TabIndex = 1;
            lblThongKe.Text = "THỐNG KÊ";
            // 
            // ThongKeBaoCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(lblThongKe);
            Controls.Add(tab);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongKeBaoCao";
            Size = new Size(945, 675);
            Load += ThongKeBaoCao_Load;
            tab.ResumeLayout(false);
            tabLuotVao.ResumeLayout(false);
            tabLuotVao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblLuotVao).EndInit();
            tabTBDuocMuon.ResumeLayout(false);
            tabTBDuocMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblTBDuocMuon).EndInit();
            tabTBDangDuocMuon.ResumeLayout(false);
            tabTBDangDuocMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblTBDangDuocMuon).EndInit();
            tabViPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblViPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tab;
        private TabPage tabLuotVao;
        private TabPage tabTBDuocMuon;
        private Label lblThongKe;
        private TabPage tabTBDangDuocMuon;
        private DateTimePicker denNgayLuotVao;
        private DateTimePicker tuNgayLuotVao;
        private TabPage tabViPham;
        private Label lblDenNgay;
        private Label lblTuNgay;
        private DataGridView tblTBDuocMuon;
        private Label label1;
        private Label label2;
        private TextBox txtTenTBDuocMuon;
        private DateTimePicker denNgayTBDuocMuon;
        private DateTimePicker tuNgayTBDuocMuon;
        private Label label3;
        private Label label4;
        private DateTimePicker denNgayTBDangDuocMuon;
        private DateTimePicker tuNgayTBDangDuocMuon;
        private DataGridView tblViPham;
        private DataGridView tblLuotVao;
        private Label lblTongSoLuong;
        private DataGridViewTextBoxColumn MaThanhVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn ChiTiet;
        private DataGridViewTextBoxColumn ThoiGian;
        private DataGridViewTextBoxColumn SoLuong;
        private Label label7;
        private DataGridViewTextBoxColumn tab2HoTen;
        private DataGridViewTextBoxColumn tab2TenThietBi;
        private DataGridViewTextBoxColumn tab2NgayMuon;
        private DataGridViewTextBoxColumn tab2NgayTra;
        private DataGridViewTextBoxColumn tab2TrangThai;
        private DataGridViewTextBoxColumn tab2SoLuong;
        private Label label8;
        private DataGridView tblTBDangDuocMuon;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox txtTenTBDangDuocMuon;
        private ComboBox cmbViPham;
        private DataGridViewTextBoxColumn tab4MaViPham;
        private DataGridViewTextBoxColumn tab4HoTen;
        private DataGridViewTextBoxColumn tab4TenViPham;
        private DataGridViewTextBoxColumn tab4MoTa;
        private DataGridViewTextBoxColumn tab4NgayVP;
        private DataGridViewTextBoxColumn tab4TrangThai;
    }
}
