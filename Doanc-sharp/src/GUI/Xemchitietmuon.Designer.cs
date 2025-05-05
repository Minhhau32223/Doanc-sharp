namespace Doanc_sharp
{
    partial class Xemchitietmuon
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
            comboBoxTrangthai = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtMathanhvien = new TextBox();
            txtMaphieumuon = new TextBox();
            label4 = new Label();
            DataThietbi = new DataGridView();
            Mathietbi = new DataGridViewTextBoxColumn();
            Tenthietbi = new DataGridViewTextBoxColumn();
            Soluong = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            txtNgaymuon = new TextBox();
            txtNgaytra = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataThietbi).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTrangthai
            // 
            comboBoxTrangthai.FormattingEnabled = true;
            comboBoxTrangthai.Location = new Point(250, 546);
            comboBoxTrangthai.Margin = new Padding(3, 2, 3, 2);
            comboBoxTrangthai.Name = "comboBoxTrangthai";
            comboBoxTrangthai.Size = new Size(295, 23);
            comboBoxTrangthai.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 71);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(314, 40);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết phiếu mượn";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(75, 545);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 23;
            label5.Text = "Trạng thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(75, 125);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 25;
            label3.Text = "Mã thành viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(75, 86);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 26;
            label2.Text = "Mã phiếu mượn:";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(409, 619);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(218, 52);
            button2.TabIndex = 21;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(75, 619);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(218, 52);
            button1.TabIndex = 22;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtMathanhvien
            // 
            txtMathanhvien.Location = new Point(250, 126);
            txtMathanhvien.Margin = new Padding(3, 2, 3, 2);
            txtMathanhvien.Name = "txtMathanhvien";
            txtMathanhvien.Size = new Size(295, 23);
            txtMathanhvien.TabIndex = 18;
            // 
            // txtMaphieumuon
            // 
            txtMaphieumuon.Location = new Point(250, 86);
            txtMaphieumuon.Margin = new Padding(3, 2, 3, 2);
            txtMaphieumuon.Name = "txtMaphieumuon";
            txtMaphieumuon.Size = new Size(295, 23);
            txtMaphieumuon.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(75, 176);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 25;
            label4.Text = "Danh sách thiết bị:";
            // 
            // DataThietbi
            // 
            DataThietbi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataThietbi.Columns.AddRange(new DataGridViewColumn[] { Mathietbi, Tenthietbi, Soluong });
            DataThietbi.Location = new Point(250, 176);
            DataThietbi.Name = "DataThietbi";
            DataThietbi.Size = new Size(295, 267);
            DataThietbi.TabIndex = 27;
            DataThietbi.CellContentClick += dataGridView1_CellContentClick;
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
            Soluong.HeaderText = "Số lượng";
            Soluong.Name = "Soluong";
            Soluong.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.Location = new Point(75, 503);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 23;
            label6.Text = "Ngày trả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.Location = new Point(75, 461);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 23;
            label7.Text = "Ngày mượn:";
            // 
            // txtNgaymuon
            // 
            txtNgaymuon.Location = new Point(250, 462);
            txtNgaymuon.Margin = new Padding(3, 2, 3, 2);
            txtNgaymuon.Name = "txtNgaymuon";
            txtNgaymuon.Size = new Size(295, 23);
            txtNgaymuon.TabIndex = 18;
            // 
            // txtNgaytra
            // 
            txtNgaytra.Location = new Point(250, 501);
            txtNgaytra.Margin = new Padding(3, 2, 3, 2);
            txtNgaytra.Name = "txtNgaytra";
            txtNgaytra.Size = new Size(295, 23);
            txtNgaytra.TabIndex = 18;
            // 
            // Xemchitietmuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 718);
            Controls.Add(DataThietbi);
            Controls.Add(comboBoxTrangthai);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNgaytra);
            Controls.Add(txtNgaymuon);
            Controls.Add(txtMathanhvien);
            Controls.Add(txtMaphieumuon);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Xemchitietmuon";
            Text = "Form2";
            Load += Xemchitietmuon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataThietbi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTrangthai;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox txtMathanhvien;
        private TextBox txtMaphieumuon;
        private Label label4;
        private DataGridView DataThietbi;
        private DataGridViewTextBoxColumn Mathietbi;
        private DataGridViewTextBoxColumn Tenthietbi;
        private DataGridViewTextBoxColumn Soluong;
        private Label label6;
        private Label label7;
        private TextBox txtNgaymuon;
        private TextBox txtNgaytra;
    }
}