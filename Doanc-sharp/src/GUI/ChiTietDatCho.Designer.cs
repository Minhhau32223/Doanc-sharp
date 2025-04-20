namespace Doanc_sharp
{
    partial class ChiTietDatCho
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnTop = new Panel();
            lblChiTietDatCho = new Label();
            lblID = new Label();
            btnXacNhan = new Button();
            btnThoat = new Button();
            txtID = new TextBox();
            lblTenThietBi = new Label();
            lblThoiGianDatCho = new Label();
            lblMaThanhVien = new Label();
            lblTrangThai = new Label();
            txtThoiGianDatCho = new TextBox();
            txtMaThanhVien = new TextBox();
            cmbTrangThai = new ComboBox();
            dataGridView1 = new DataGridView();
            IDTB = new DataGridViewTextBoxColumn();
            Tentb = new DataGridViewTextBoxColumn();
            Soluong = new DataGridViewTextBoxColumn();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.NavajoWhite;
            pnTop.Controls.Add(lblChiTietDatCho);
            pnTop.Location = new Point(1, 1);
            pnTop.Margin = new Padding(3, 2, 3, 2);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(879, 71);
            pnTop.TabIndex = 17;
            // 
            // lblChiTietDatCho
            // 
            lblChiTietDatCho.AutoSize = true;
            lblChiTietDatCho.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChiTietDatCho.ForeColor = Color.Red;
            lblChiTietDatCho.Location = new Point(27, 16);
            lblChiTietDatCho.Name = "lblChiTietDatCho";
            lblChiTietDatCho.Size = new Size(248, 40);
            lblChiTietDatCho.TabIndex = 0;
            lblChiTietDatCho.Text = "Chi tiết đặt chỗ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Times New Roman", 13.8F);
            lblID.Location = new Point(193, 88);
            lblID.Name = "lblID";
            lblID.Size = new Size(33, 21);
            lblID.TabIndex = 30;
            lblID.Text = "ID:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Green;
            btnXacNhan.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = SystemColors.ButtonHighlight;
            btnXacNhan.Location = new Point(477, 442);
            btnXacNhan.Margin = new Padding(3, 2, 3, 2);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(218, 52);
            btnXacNhan.TabIndex = 28;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(155, 442);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(218, 52);
            btnThoat.TabIndex = 29;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(424, 88);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(297, 23);
            txtID.TabIndex = 27;
            // 
            // lblTenThietBi
            // 
            lblTenThietBi.AutoSize = true;
            lblTenThietBi.Font = new Font("Times New Roman", 13.8F);
            lblTenThietBi.Location = new Point(193, 122);
            lblTenThietBi.Name = "lblTenThietBi";
            lblTenThietBi.Size = new Size(98, 21);
            lblTenThietBi.TabIndex = 31;
            lblTenThietBi.Text = "Tên thiết bị:";
            // 
            // lblThoiGianDatCho
            // 
            lblThoiGianDatCho.AutoSize = true;
            lblThoiGianDatCho.Font = new Font("Times New Roman", 13.8F);
            lblThoiGianDatCho.Location = new Point(193, 214);
            lblThoiGianDatCho.Name = "lblThoiGianDatCho";
            lblThoiGianDatCho.Size = new Size(145, 21);
            lblThoiGianDatCho.TabIndex = 32;
            lblThoiGianDatCho.Text = "Thời gian đặt chỗ:";
            // 
            // lblMaThanhVien
            // 
            lblMaThanhVien.AutoSize = true;
            lblMaThanhVien.Font = new Font("Times New Roman", 13.8F);
            lblMaThanhVien.Location = new Point(193, 264);
            lblMaThanhVien.Name = "lblMaThanhVien";
            lblMaThanhVien.Size = new Size(118, 21);
            lblMaThanhVien.TabIndex = 34;
            lblMaThanhVien.Text = "Mã thành viên:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Times New Roman", 13.8F);
            lblTrangThai.Location = new Point(193, 316);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(88, 21);
            lblTrangThai.TabIndex = 35;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // txtThoiGianDatCho
            // 
            txtThoiGianDatCho.Location = new Point(424, 214);
            txtThoiGianDatCho.Margin = new Padding(3, 2, 3, 2);
            txtThoiGianDatCho.Name = "txtThoiGianDatCho";
            txtThoiGianDatCho.Size = new Size(297, 23);
            txtThoiGianDatCho.TabIndex = 37;
            // 
            // txtMaThanhVien
            // 
            txtMaThanhVien.Location = new Point(424, 262);
            txtMaThanhVien.Margin = new Padding(3, 2, 3, 2);
            txtMaThanhVien.Name = "txtMaThanhVien";
            txtMaThanhVien.Size = new Size(297, 23);
            txtMaThanhVien.TabIndex = 39;
            txtMaThanhVien.TextChanged += txtMaThanhVien_TextChanged;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "Đang chờ", "Đã hủy", "Xác nhận mượn" });
            cmbTrangThai.Location = new Point(424, 314);
            cmbTrangThai.Margin = new Padding(3, 2, 3, 2);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(297, 23);
            cmbTrangThai.TabIndex = 42;
            cmbTrangThai.SelectedIndexChanged += cmbTrangThai_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDTB, Tentb, Soluong });
            dataGridView1.Location = new Point(422, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(303, 64);
            dataGridView1.TabIndex = 43;
            // 
            // IDTB
            // 
            IDTB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IDTB.DataPropertyName = "Mathietbi";
            IDTB.HeaderText = "ID Thiết bị";
            IDTB.Name = "IDTB";
            // 
            // Tentb
            // 
            Tentb.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tentb.DataPropertyName = "Tenthietbi";
            Tentb.HeaderText = "Tên thiết bị";
            Tentb.Name = "Tentb";
            // 
            // Soluong
            // 
            Soluong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Soluong.DataPropertyName = "Soluong";
            Soluong.HeaderText = "Số lượng";
            Soluong.Name = "Soluong";
            // 
            // ChiTietDatCho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(880, 550);
            Controls.Add(dataGridView1);
            Controls.Add(cmbTrangThai);
            Controls.Add(txtMaThanhVien);
            Controls.Add(txtThoiGianDatCho);
            Controls.Add(lblTrangThai);
            Controls.Add(lblMaThanhVien);
            Controls.Add(lblThoiGianDatCho);
            Controls.Add(lblTenThietBi);
            Controls.Add(lblID);
            Controls.Add(btnXacNhan);
            Controls.Add(btnThoat);
            Controls.Add(txtID);
            Controls.Add(pnTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChiTietDatCho";
            Text = "ChiTietDatCho";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnTop;
        private Label lblChiTietDatCho;
        private Label lblID;
        private Button btnXacNhan;
        private Button btnThoat;
        private TextBox txtID;
        private Label lblTenThietBi;
        private Label lblThoiGianDatCho;
        private Label lblMaThanhVien;
        private Label lblTrangThai;
        private TextBox txtThoiGianDatCho;
        private TextBox txtMaThanhVien;
        private ComboBox cmbTrangThai;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDTB;
        private DataGridViewTextBoxColumn Tentb;
        private DataGridViewTextBoxColumn Soluong;
    }
}