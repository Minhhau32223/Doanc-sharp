namespace Doanc_sharp
{
    partial class Themphieumuon
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
            panel1 = new Panel();
            labelTitle = new Label();
            BtnXacnhan = new Button();
            BtnThoat = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            CbbTrangthai = new ComboBox();
            textBoxMaphieumuon = new TextBox();
            txtMathanhvien = new TextBox();
            textNgaytra = new TextBox();
            btnThem = new Button();
            Datatbmuon = new DataGridView();
            Mathietbi = new DataGridViewTextBoxColumn();
            Tenthietbi = new DataGridViewTextBoxColumn();
            Soluong = new DataGridViewTextBoxColumn();
            label6 = new Label();
            txtSoluong = new TextBox();
            txtMatb = new TextBox();
            txtNgayMuon = new TextBox();
            label9 = new Label();
            Btnbo = new Button();
            label1 = new Label();
            textBoxsongaymuon = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Datatbmuon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 71);
            panel1.TabIndex = 16;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Red;
            labelTitle.Location = new Point(27, 16);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(288, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thêm phiếu mượn";
            // 
            // BtnXacnhan
            // 
            BtnXacnhan.BackColor = Color.Green;
            BtnXacnhan.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnXacnhan.ForeColor = SystemColors.ButtonHighlight;
            BtnXacnhan.Location = new Point(402, 572);
            BtnXacnhan.Margin = new Padding(3, 2, 3, 2);
            BtnXacnhan.Name = "BtnXacnhan";
            BtnXacnhan.Size = new Size(218, 52);
            BtnXacnhan.TabIndex = 21;
            BtnXacnhan.Text = "Xác nhận";
            BtnXacnhan.UseVisualStyleBackColor = false;
            BtnXacnhan.Click += BtnXacnhan_Click;
            // 
            // BtnThoat
            // 
            BtnThoat.BackColor = Color.Red;
            BtnThoat.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnThoat.ForeColor = SystemColors.ButtonHighlight;
            BtnThoat.Location = new Point(69, 572);
            BtnThoat.Margin = new Padding(3, 2, 3, 2);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(218, 52);
            BtnThoat.TabIndex = 22;
            BtnThoat.Text = "Thoát";
            BtnThoat.UseVisualStyleBackColor = false;
            BtnThoat.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 86);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 23;
            label2.Text = "Mã phiếu mượn";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 133);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 24;
            label3.Text = "Mã thành viên";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 263);
            label4.Name = "label4";
            label4.Size = new Size(149, 23);
            label4.TabIndex = 25;
            label4.Text = "Ngày trả dự kiến";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(551, 318);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 25;
            label5.Text = "Nhập mã thiết bị";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(77, 318);
            label7.Name = "label7";
            label7.Size = new Size(160, 23);
            label7.TabIndex = 27;
            label7.Text = "Danh sách thiết bị";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(77, 533);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
            label8.TabIndex = 28;
            label8.Text = "Trạng thái";
            label8.Click += label8_Click;
            // 
            // CbbTrangthai
            // 
            CbbTrangthai.FormattingEnabled = true;
            CbbTrangthai.Items.AddRange(new object[] { "Đang mượn" });
            CbbTrangthai.Location = new Point(260, 533);
            CbbTrangthai.Name = "CbbTrangthai";
            CbbTrangthai.Size = new Size(290, 23);
            CbbTrangthai.TabIndex = 29;
            CbbTrangthai.SelectedIndexChanged += CbbTrangthai_SelectedIndexChanged;
            // 
            // textBoxMaphieumuon
            // 
            textBoxMaphieumuon.Location = new Point(260, 89);
            textBoxMaphieumuon.Name = "textBoxMaphieumuon";
            textBoxMaphieumuon.Size = new Size(291, 23);
            textBoxMaphieumuon.TabIndex = 30;
            // 
            // txtMathanhvien
            // 
            txtMathanhvien.Location = new Point(260, 136);
            txtMathanhvien.Name = "txtMathanhvien";
            txtMathanhvien.Size = new Size(291, 23);
            txtMathanhvien.TabIndex = 31;
            // 
            // textNgaytra
            // 
            textNgaytra.Location = new Point(260, 266);
            textNgaytra.Name = "textNgaytra";
            textNgaytra.Size = new Size(291, 23);
            textNgaytra.TabIndex = 33;
            textNgaytra.Text = "null";
            textNgaytra.TextChanged += textBox2_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(556, 486);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 23);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Datatbmuon
            // 
            Datatbmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datatbmuon.Columns.AddRange(new DataGridViewColumn[] { Mathietbi, Tenthietbi, Soluong });
            Datatbmuon.Location = new Point(260, 318);
            Datatbmuon.Name = "Datatbmuon";
            Datatbmuon.Size = new Size(290, 191);
            Datatbmuon.TabIndex = 36;
            // 
            // Mathietbi
            // 
            Mathietbi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mathietbi.DataPropertyName = "Mathietbi";
            Mathietbi.HeaderText = "Mã thiết bị";
            Mathietbi.Name = "Mathietbi";
            Mathietbi.ReadOnly = true;
            Mathietbi.Resizable = DataGridViewTriState.False;
            // 
            // Tenthietbi
            // 
            Tenthietbi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tenthietbi.DataPropertyName = "Tenthietbi";
            Tenthietbi.HeaderText = "Tên thiết bị";
            Tenthietbi.Name = "Tenthietbi";
            Tenthietbi.ReadOnly = true;
            Tenthietbi.Resizable = DataGridViewTriState.False;
            // 
            // Soluong
            // 
            Soluong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Soluong.DataPropertyName = "Soluong";
            Soluong.HeaderText = "Soluong";
            Soluong.Name = "Soluong";
            Soluong.ReadOnly = true;
            Soluong.Resizable = DataGridViewTriState.False;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(576, 392);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 25;
            label6.Text = "Số lượng";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(563, 432);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(125, 23);
            txtSoluong.TabIndex = 32;
            // 
            // txtMatb
            // 
            txtMatb.Location = new Point(563, 355);
            txtMatb.Name = "txtMatb";
            txtMatb.Size = new Size(125, 23);
            txtMatb.TabIndex = 32;
            // 
            // txtNgayMuon
            // 
            txtNgayMuon.Location = new Point(260, 177);
            txtNgayMuon.Name = "txtNgayMuon";
            txtNgayMuon.Size = new Size(291, 23);
            txtNgayMuon.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(77, 177);
            label9.Name = "label9";
            label9.Size = new Size(109, 23);
            label9.TabIndex = 25;
            label9.Text = "Ngày mượn";
            label9.Click += label9_Click;
            // 
            // Btnbo
            // 
            Btnbo.Location = new Point(638, 486);
            Btnbo.Name = "Btnbo";
            Btnbo.Size = new Size(55, 23);
            Btnbo.TabIndex = 38;
            Btnbo.Text = "Bỏ";
            Btnbo.UseVisualStyleBackColor = true;
            Btnbo.Click += Btnbo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 219);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 25;
            label1.Text = "Số ngày mượn";
            // 
            // textBoxsongaymuon
            // 
            textBoxsongaymuon.Location = new Point(259, 222);
            textBoxsongaymuon.Name = "textBoxsongaymuon";
            textBoxsongaymuon.Size = new Size(291, 23);
            textBoxsongaymuon.TabIndex = 33;
            textBoxsongaymuon.TextChanged += textBox2_TextChanged;
            // 
            // Themphieumuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 671);
            Controls.Add(Btnbo);
            Controls.Add(Datatbmuon);
            Controls.Add(btnThem);
            Controls.Add(textBoxsongaymuon);
            Controls.Add(textNgaytra);
            Controls.Add(txtMatb);
            Controls.Add(txtSoluong);
            Controls.Add(txtNgayMuon);
            Controls.Add(txtMathanhvien);
            Controls.Add(textBoxMaphieumuon);
            Controls.Add(CbbTrangthai);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(BtnXacnhan);
            Controls.Add(BtnThoat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Themphieumuon";
            Text = "Form3";
            Load += Themphieumuon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Datatbmuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label labelTitle;
        private Button BtnXacnhan;
        private Button BtnThoat;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private ComboBox CbbTrangthai;
        private TextBox textBoxMaphieumuon;
        private TextBox txtMathanhvien;
        private TextBox textNgaytra;
        private ListView listView1;
        private Button btnThem;
        private DataGridView Datatbmuon;
        private DataGridViewTextBoxColumn Mathietbi;
        private DataGridViewTextBoxColumn Tenthietbi;
        private DataGridViewTextBoxColumn Soluong;
        private Label label6;
        private TextBox txtSoluong;
        private TextBox txtMatb;
        private TextBox txtNgayMuon;
        private Label label9;
        private Button Btnbo;
        private Label label1;
        private TextBox textBoxsongaymuon;
    }
}