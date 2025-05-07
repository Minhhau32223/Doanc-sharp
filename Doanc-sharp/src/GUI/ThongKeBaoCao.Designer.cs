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
            pnBieuDo = new Panel();
            tabThongKe = new TabControl();
            tabLuotVao = new TabPage();
            time1LuotVao = new DateTimePicker();
            time2LuotVao = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            tabMuonThietBi = new TabPage();
            time1MuonThietBi = new DateTimePicker();
            time2MuonThietBi = new DateTimePicker();
            label6 = new Label();
            label8 = new Label();
            tabDoanhThu = new TabPage();
            time1DoanhThu = new DateTimePicker();
            time2DoanhThu = new DateTimePicker();
            label10 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            lblNhanVien = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lblThietBi = new Label();
            label9 = new Label();
            panel4 = new Panel();
            lblThanhVien = new Label();
            label11 = new Label();
            label14 = new Label();
            panel6 = new Panel();
            lblViPham = new Label();
            label16 = new Label();
            label19 = new Label();
            tblDatCho = new DataGridView();
            MaTVDatCho = new DataGridViewTextBoxColumn();
            ThoiGianDat = new DataGridViewTextBoxColumn();
            TrangThaiDatCho = new DataGridViewTextBoxColumn();
            tblLichSu = new DataGridView();
            MaTVLichSu = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            label20 = new Label();
            btnChiTietLichSu = new Button();
            btnChiTietDatCho = new Button();
            btnChiTietViPham = new Button();
            tblViPham = new DataGridView();
            MaViPham = new DataGridViewTextBoxColumn();
            Hoten = new DataGridViewTextBoxColumn();
            TenViPham = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnChiTietMuonTra = new Button();
            label7 = new Label();
            tblMuonTra = new DataGridView();
            MaTVMuonTra = new DataGridViewTextBoxColumn();
            NgayMuon = new DataGridViewTextBoxColumn();
            NgayTra = new DataGridViewTextBoxColumn();
            TrangThaiMuonTra = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnBieuDo.SuspendLayout();
            tabThongKe.SuspendLayout();
            tabLuotVao.SuspendLayout();
            tabMuonThietBi.SuspendLayout();
            tabDoanhThu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblDatCho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblLichSu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblViPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblMuonTra).BeginInit();
            SuspendLayout();
            // 
            // pnBieuDo
            // 
            pnBieuDo.BackColor = Color.NavajoWhite;
            pnBieuDo.Controls.Add(tabThongKe);
            pnBieuDo.Location = new Point(3, 0);
            pnBieuDo.Margin = new Padding(3, 2, 3, 2);
            pnBieuDo.Name = "pnBieuDo";
            pnBieuDo.Size = new Size(708, 342);
            pnBieuDo.TabIndex = 0;
            // 
            // tabThongKe
            // 
            tabThongKe.Controls.Add(tabLuotVao);
            tabThongKe.Controls.Add(tabMuonThietBi);
            tabThongKe.Controls.Add(tabDoanhThu);
            tabThongKe.Location = new Point(3, 3);
            tabThongKe.Name = "tabThongKe";
            tabThongKe.SelectedIndex = 0;
            tabThongKe.Size = new Size(705, 339);
            tabThongKe.TabIndex = 7;
            // 
            // tabLuotVao
            // 
            tabLuotVao.Controls.Add(time1LuotVao);
            tabLuotVao.Controls.Add(time2LuotVao);
            tabLuotVao.Controls.Add(label2);
            tabLuotVao.Controls.Add(label1);
            tabLuotVao.Location = new Point(4, 24);
            tabLuotVao.Name = "tabLuotVao";
            tabLuotVao.Padding = new Padding(3);
            tabLuotVao.Size = new Size(697, 311);
            tabLuotVao.TabIndex = 0;
            tabLuotVao.Text = "Lượt vào";
            tabLuotVao.UseVisualStyleBackColor = true;
            // 
            // time1LuotVao
            // 
            time1LuotVao.Location = new Point(244, 5);
            time1LuotVao.Margin = new Padding(3, 2, 3, 2);
            time1LuotVao.Name = "time1LuotVao";
            time1LuotVao.Size = new Size(201, 23);
            time1LuotVao.TabIndex = 2;
            time1LuotVao.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // time2LuotVao
            // 
            time2LuotVao.Location = new Point(490, 5);
            time2LuotVao.Margin = new Padding(3, 2, 3, 2);
            time2LuotVao.Name = "time2LuotVao";
            time2LuotVao.Size = new Size(201, 23);
            time2LuotVao.TabIndex = 3;
            time2LuotVao.ValueChanged += time2LuotVao_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 7);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "Đến:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 7);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 4;
            label1.Text = "Từ:";
            // 
            // tabMuonThietBi
            // 
            tabMuonThietBi.Controls.Add(time1MuonThietBi);
            tabMuonThietBi.Controls.Add(time2MuonThietBi);
            tabMuonThietBi.Controls.Add(label6);
            tabMuonThietBi.Controls.Add(label8);
            tabMuonThietBi.Location = new Point(4, 24);
            tabMuonThietBi.Name = "tabMuonThietBi";
            tabMuonThietBi.Padding = new Padding(3);
            tabMuonThietBi.Size = new Size(697, 311);
            tabMuonThietBi.TabIndex = 1;
            tabMuonThietBi.Text = "Mượn thiết bị";
            tabMuonThietBi.UseVisualStyleBackColor = true;
            // 
            // time1MuonThietBi
            // 
            time1MuonThietBi.Location = new Point(244, 2);
            time1MuonThietBi.Margin = new Padding(3, 2, 3, 2);
            time1MuonThietBi.Name = "time1MuonThietBi";
            time1MuonThietBi.Size = new Size(201, 23);
            time1MuonThietBi.TabIndex = 6;
            time1MuonThietBi.ValueChanged += time1MuonThietBi_ValueChanged;
            // 
            // time2MuonThietBi
            // 
            time2MuonThietBi.Location = new Point(490, 2);
            time2MuonThietBi.Margin = new Padding(3, 2, 3, 2);
            time2MuonThietBi.Name = "time2MuonThietBi";
            time2MuonThietBi.Size = new Size(201, 23);
            time2MuonThietBi.TabIndex = 7;
            time2MuonThietBi.ValueChanged += time2MuonThietBi_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(451, 4);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 9;
            label6.Text = "Đến:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 4);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 8;
            label8.Text = "Từ:";
            // 
            // tabDoanhThu
            // 
            tabDoanhThu.Controls.Add(time1DoanhThu);
            tabDoanhThu.Controls.Add(time2DoanhThu);
            tabDoanhThu.Controls.Add(label10);
            tabDoanhThu.Controls.Add(label12);
            tabDoanhThu.Location = new Point(4, 24);
            tabDoanhThu.Name = "tabDoanhThu";
            tabDoanhThu.Padding = new Padding(3);
            tabDoanhThu.Size = new Size(697, 311);
            tabDoanhThu.TabIndex = 2;
            tabDoanhThu.Text = "Doanh thu";
            tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // time1DoanhThu
            // 
            time1DoanhThu.Location = new Point(247, 2);
            time1DoanhThu.Margin = new Padding(3, 2, 3, 2);
            time1DoanhThu.Name = "time1DoanhThu";
            time1DoanhThu.Size = new Size(201, 23);
            time1DoanhThu.TabIndex = 6;
            time1DoanhThu.ValueChanged += time1DoanhThu_ValueChanged;
            // 
            // time2DoanhThu
            // 
            time2DoanhThu.Location = new Point(493, 2);
            time2DoanhThu.Margin = new Padding(3, 2, 3, 2);
            time2DoanhThu.Name = "time2DoanhThu";
            time2DoanhThu.Size = new Size(201, 23);
            time2DoanhThu.TabIndex = 7;
            time2DoanhThu.ValueChanged += time2DoanhThu_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(454, 4);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 9;
            label10.Text = "Đến:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(217, 4);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 8;
            label12.Text = "Từ:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(lblNhanVien);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(713, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 83);
            panel1.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 25F);
            lblNhanVien.ForeColor = Color.White;
            lblNhanVien.Location = new Point(91, 21);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(56, 46);
            lblNhanVien.TabIndex = 1;
            lblNhanVien.Text = "12";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 0;
            label4.Text = "Nhân viên";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Peru;
            panel3.Controls.Add(lblThietBi);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(713, 178);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 83);
            panel3.TabIndex = 3;
            // 
            // lblThietBi
            // 
            lblThietBi.AutoSize = true;
            lblThietBi.Font = new Font("Segoe UI", 25F);
            lblThietBi.ForeColor = Color.White;
            lblThietBi.Location = new Point(62, 21);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(105, 46);
            lblThietBi.TabIndex = 2;
            lblThietBi.Text = "12/20";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 0;
            label9.Text = "Thiết bị";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Peru;
            panel4.Controls.Add(lblThanhVien);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(713, 90);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 83);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // lblThanhVien
            // 
            lblThanhVien.AutoSize = true;
            lblThanhVien.Font = new Font("Segoe UI", 25F);
            lblThanhVien.ForeColor = Color.White;
            lblThanhVien.Location = new Point(91, 23);
            lblThanhVien.Name = "lblThanhVien";
            lblThanhVien.Size = new Size(56, 46);
            lblThanhVien.TabIndex = 2;
            lblThanhVien.Text = "12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(86, 21);
            label11.TabIndex = 0;
            label11.Text = "Thành viên";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(300, 344);
            label14.Name = "label14";
            label14.Size = new Size(76, 21);
            label14.TabIndex = 7;
            label14.Text = "GẦN ĐÂY";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Peru;
            panel6.Controls.Add(lblViPham);
            panel6.Controls.Add(label16);
            panel6.Location = new Point(713, 266);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(229, 83);
            panel6.TabIndex = 6;
            // 
            // lblViPham
            // 
            lblViPham.AutoSize = true;
            lblViPham.Font = new Font("Segoe UI", 25F);
            lblViPham.ForeColor = Color.White;
            lblViPham.Location = new Point(80, 24);
            lblViPham.Name = "lblViPham";
            lblViPham.Size = new Size(87, 46);
            lblViPham.TabIndex = 2;
            lblViPham.Text = "2/12";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(68, 21);
            label16.TabIndex = 0;
            label16.Text = "Vi phạm";
            label16.Click += label16_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(351, 516);
            label19.Name = "label19";
            label19.Size = new Size(210, 21);
            label19.TabIndex = 14;
            label19.Text = "Lịch sử hoạt động thành viên";
            // 
            // tblDatCho
            // 
            tblDatCho.BackgroundColor = Color.NavajoWhite;
            tblDatCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblDatCho.Columns.AddRange(new DataGridViewColumn[] { MaTVDatCho, ThoiGianDat, TrangThaiDatCho });
            tblDatCho.Location = new Point(3, 388);
            tblDatCho.Margin = new Padding(3, 2, 3, 2);
            tblDatCho.Name = "tblDatCho";
            tblDatCho.RowHeadersWidth = 51;
            tblDatCho.Size = new Size(335, 124);
            tblDatCho.TabIndex = 13;
            tblDatCho.CellContentClick += tblDatCho_CellContentClick;
            // 
            // MaTVDatCho
            // 
            MaTVDatCho.DataPropertyName = "Mathanhvien";
            MaTVDatCho.HeaderText = "Mã TV";
            MaTVDatCho.MinimumWidth = 6;
            MaTVDatCho.Name = "MaTVDatCho";
            MaTVDatCho.Width = 70;
            // 
            // ThoiGianDat
            // 
            ThoiGianDat.DataPropertyName = "Thoigiandat";
            ThoiGianDat.HeaderText = "Thời gian đặt";
            ThoiGianDat.MinimumWidth = 6;
            ThoiGianDat.Name = "ThoiGianDat";
            ThoiGianDat.Width = 120;
            // 
            // TrangThaiDatCho
            // 
            TrangThaiDatCho.DataPropertyName = "Trangthai";
            TrangThaiDatCho.HeaderText = "Trạng thái";
            TrangThaiDatCho.MinimumWidth = 6;
            TrangThaiDatCho.Name = "TrangThaiDatCho";
            TrangThaiDatCho.Width = 103;
            // 
            // tblLichSu
            // 
            tblLichSu.BackgroundColor = Color.NavajoWhite;
            tblLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblLichSu.Columns.AddRange(new DataGridViewColumn[] { MaTVLichSu, Loai, ThoiGian });
            tblLichSu.Location = new Point(351, 543);
            tblLichSu.Margin = new Padding(3, 2, 3, 2);
            tblLichSu.Name = "tblLichSu";
            tblLichSu.RowHeadersWidth = 51;
            tblLichSu.Size = new Size(335, 122);
            tblLichSu.TabIndex = 12;
            // 
            // MaTVLichSu
            // 
            MaTVLichSu.DataPropertyName = "Mathanhvien";
            MaTVLichSu.HeaderText = "Thành viên";
            MaTVLichSu.MinimumWidth = 6;
            MaTVLichSu.Name = "MaTVLichSu";
            MaTVLichSu.Width = 90;
            // 
            // Loai
            // 
            Loai.DataPropertyName = "Loai";
            Loai.HeaderText = "Loại";
            Loai.MinimumWidth = 6;
            Loai.Name = "Loai";
            Loai.Width = 125;
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "Thoigian";
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.MinimumWidth = 6;
            ThoiGian.Name = "ThoiGian";
            ThoiGian.Width = 125;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(4, 365);
            label20.Name = "label20";
            label20.Size = new Size(63, 21);
            label20.TabIndex = 11;
            label20.Text = "Đặt chỗ";
            // 
            // btnChiTietLichSu
            // 
            btnChiTietLichSu.BackColor = Color.Peru;
            btnChiTietLichSu.ForeColor = Color.White;
            btnChiTietLichSu.Location = new Point(586, 516);
            btnChiTietLichSu.Margin = new Padding(3, 2, 3, 2);
            btnChiTietLichSu.Name = "btnChiTietLichSu";
            btnChiTietLichSu.Size = new Size(100, 22);
            btnChiTietLichSu.TabIndex = 17;
            btnChiTietLichSu.Text = "Xem chi tiết";
            btnChiTietLichSu.UseVisualStyleBackColor = false;
            btnChiTietLichSu.Click += btnChiTietLichSu_Click;
            // 
            // btnChiTietDatCho
            // 
            btnChiTietDatCho.BackColor = Color.Peru;
            btnChiTietDatCho.ForeColor = Color.White;
            btnChiTietDatCho.Location = new Point(83, 364);
            btnChiTietDatCho.Margin = new Padding(3, 2, 3, 2);
            btnChiTietDatCho.Name = "btnChiTietDatCho";
            btnChiTietDatCho.Size = new Size(100, 22);
            btnChiTietDatCho.TabIndex = 18;
            btnChiTietDatCho.Text = "Xem chi tiết";
            btnChiTietDatCho.UseVisualStyleBackColor = false;
            btnChiTietDatCho.Click += btnChiTietDatCho_Click;
            // 
            // btnChiTietViPham
            // 
            btnChiTietViPham.BackColor = Color.Peru;
            btnChiTietViPham.ForeColor = Color.White;
            btnChiTietViPham.Location = new Point(88, 517);
            btnChiTietViPham.Margin = new Padding(3, 2, 3, 2);
            btnChiTietViPham.Name = "btnChiTietViPham";
            btnChiTietViPham.Size = new Size(100, 22);
            btnChiTietViPham.TabIndex = 21;
            btnChiTietViPham.Text = "Xem chi tiết";
            btnChiTietViPham.UseVisualStyleBackColor = false;
            btnChiTietViPham.Click += btnChiTietViPham_Click;
            // 
            // tblViPham
            // 
            tblViPham.BackgroundColor = Color.NavajoWhite;
            tblViPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblViPham.Columns.AddRange(new DataGridViewColumn[] { MaViPham, Hoten, TenViPham, TrangThai });
            tblViPham.Location = new Point(3, 543);
            tblViPham.Margin = new Padding(3, 2, 3, 2);
            tblViPham.Name = "tblViPham";
            tblViPham.RowHeadersWidth = 51;
            tblViPham.Size = new Size(335, 122);
            tblViPham.TabIndex = 20;
            // 
            // MaViPham
            // 
            MaViPham.DataPropertyName = "Mavipham";
            MaViPham.HeaderText = "Mã vi phạm";
            MaViPham.MinimumWidth = 6;
            MaViPham.Name = "MaViPham";
            MaViPham.Width = 107;
            // 
            // Hoten
            // 
            Hoten.DataPropertyName = "HoTen";
            Hoten.HeaderText = "Họ tên";
            Hoten.Name = "Hoten";
            // 
            // TenViPham
            // 
            TenViPham.DataPropertyName = "Tenvipham";
            TenViPham.HeaderText = "Tên vi phạm";
            TenViPham.MinimumWidth = 6;
            TenViPham.Name = "TenViPham";
            TenViPham.Width = 120;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "Trangthai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.Width = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(10, 517);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 19;
            label5.Text = "Vi phạm";
            // 
            // btnChiTietMuonTra
            // 
            btnChiTietMuonTra.BackColor = Color.Peru;
            btnChiTietMuonTra.ForeColor = Color.White;
            btnChiTietMuonTra.Location = new Point(436, 362);
            btnChiTietMuonTra.Margin = new Padding(3, 2, 3, 2);
            btnChiTietMuonTra.Name = "btnChiTietMuonTra";
            btnChiTietMuonTra.Size = new Size(100, 22);
            btnChiTietMuonTra.TabIndex = 24;
            btnChiTietMuonTra.Text = "Xem chi tiết";
            btnChiTietMuonTra.UseVisualStyleBackColor = false;
            btnChiTietMuonTra.Click += btnChiTietMuonTra_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(355, 365);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 23;
            label7.Text = "Mượn trả";
            // 
            // tblMuonTra
            // 
            tblMuonTra.BackgroundColor = Color.NavajoWhite;
            tblMuonTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMuonTra.Columns.AddRange(new DataGridViewColumn[] { MaTVMuonTra, NgayMuon, NgayTra, TrangThaiMuonTra });
            tblMuonTra.Location = new Point(351, 388);
            tblMuonTra.Margin = new Padding(3, 2, 3, 2);
            tblMuonTra.Name = "tblMuonTra";
            tblMuonTra.RowHeadersWidth = 51;
            tblMuonTra.Size = new Size(335, 124);
            tblMuonTra.TabIndex = 22;
            // 
            // MaTVMuonTra
            // 
            MaTVMuonTra.DataPropertyName = "Mathanhvien";
            MaTVMuonTra.HeaderText = "Mã TV";
            MaTVMuonTra.MinimumWidth = 6;
            MaTVMuonTra.Name = "MaTVMuonTra";
            MaTVMuonTra.Width = 70;
            // 
            // NgayMuon
            // 
            NgayMuon.DataPropertyName = "Ngaymuon";
            NgayMuon.HeaderText = "Ngày mượn";
            NgayMuon.MinimumWidth = 6;
            NgayMuon.Name = "NgayMuon";
            NgayMuon.Width = 110;
            // 
            // NgayTra
            // 
            NgayTra.DataPropertyName = "Ngaytra";
            NgayTra.HeaderText = "Ngày trả";
            NgayTra.MinimumWidth = 6;
            NgayTra.Name = "NgayTra";
            NgayTra.Width = 110;
            // 
            // TrangThaiMuonTra
            // 
            TrangThaiMuonTra.DataPropertyName = "Trangthai";
            TrangThaiMuonTra.HeaderText = "Trạng thái";
            TrangThaiMuonTra.Name = "TrangThaiMuonTra";
            // 
            // ThongKeBaoCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(btnChiTietMuonTra);
            Controls.Add(label7);
            Controls.Add(tblMuonTra);
            Controls.Add(btnChiTietViPham);
            Controls.Add(tblViPham);
            Controls.Add(label5);
            Controls.Add(btnChiTietDatCho);
            Controls.Add(btnChiTietLichSu);
            Controls.Add(label19);
            Controls.Add(tblDatCho);
            Controls.Add(tblLichSu);
            Controls.Add(label20);
            Controls.Add(panel6);
            Controls.Add(label14);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pnBieuDo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongKeBaoCao";
            Size = new Size(945, 675);
            Load += ThongKeBaoCao_Load;
            pnBieuDo.ResumeLayout(false);
            tabThongKe.ResumeLayout(false);
            tabLuotVao.ResumeLayout(false);
            tabLuotVao.PerformLayout();
            tabMuonThietBi.ResumeLayout(false);
            tabMuonThietBi.PerformLayout();
            tabDoanhThu.ResumeLayout(false);
            tabDoanhThu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblDatCho).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblLichSu).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblViPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblMuonTra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnBieuDo;
        private DateTimePicker time1LuotVao;
        private Label label2;
        private Label label1;
        private DateTimePicker time2LuotVao;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label lblNhanVien;
        private Panel panel3;
        private Label lblThietBi;
        private Label label9;
        private Panel panel4;
        private Label lblThanhVien;
        private Label label11;
        private Label label14;
        private Panel panel6;
        private Label lblViPham;
        private Label label16;
        private Label label19;
        private DataGridView tblDatCho;
        private DataGridView tblLichSu;
        private Label label20;
        private Button btnChiTietLichSu;
        private Button btnChiTietDatCho;
        private Button btnChiTietViPham;
        private DataGridView tblViPham;
        private Label label5;
        private Button btnChiTietMuonTra;
        private Label label7;
        private DataGridView tblMuonTra;
        private TabControl tabThongKe;
        private TabPage tabLuotVao;
        private TabPage tabMuonThietBi;
        private TabPage tabDoanhThu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn MaTVDatCho;
        private DataGridViewTextBoxColumn ThoiGianDat;
        private DataGridViewTextBoxColumn TrangThaiDatCho;
        private DataGridViewTextBoxColumn MaTVMuonTra;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn TrangThaiMuonTra;
        private DataGridViewTextBoxColumn MaTVLichSu;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn ThoiGian;
        private DataGridViewTextBoxColumn MaViPham;
        private DataGridViewTextBoxColumn Hoten;
        private DataGridViewTextBoxColumn TenViPham;
        private DataGridViewTextBoxColumn TrangThai;
        private DateTimePicker time1MuonThietBi;
        private DateTimePicker time2MuonThietBi;
        private Label label6;
        private Label label8;
        private DateTimePicker time1DoanhThu;
        private DateTimePicker time2DoanhThu;
        private Label label10;
        private Label label12;
    }
}
