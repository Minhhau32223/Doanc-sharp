namespace Doanc_sharp
{
    partial class Muontra
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            TextBoxTimkiem = new TextBox();
            label3 = new Label();
            BtnDelete = new Button();
            btnCapnhat = new Button();
            button2 = new Button();
            BtnAdd = new Button();
            DataMuon = new DataGridView();
            Maphieumuon = new DataGridViewTextBoxColumn();
            Ngaymuon = new DataGridViewTextBoxColumn();
            Ngaytra = new DataGridViewTextBoxColumn();
            Mathanhvien = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            button1 = new Button();
            dataTra = new DataGridView();
            Maphieumuon1 = new DataGridViewTextBoxColumn();
            Ngaymuon1 = new DataGridViewTextBoxColumn();
            Ngaytra1 = new DataGridViewTextBoxColumn();
            Mathanhvien1 = new DataGridViewTextBoxColumn();
            Trangthai1 = new DataGridViewTextBoxColumn();
            textBoxTimkiemtra = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataMuon).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTra).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(236, 36);
            label1.TabIndex = 3;
            label1.Text = "Quản lý mượn trả";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(34, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(845, 560);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(TextBoxTimkiem);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(btnCapnhat);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(BtnAdd);
            tabPage1.Controls.Add(DataMuon);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(837, 532);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh sách mượn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // TextBoxTimkiem
            // 
            TextBoxTimkiem.Location = new Point(135, 15);
            TextBoxTimkiem.Name = "TextBoxTimkiem";
            TextBoxTimkiem.Size = new Size(175, 23);
            TextBoxTimkiem.TabIndex = 12;
            TextBoxTimkiem.TextChanged += TextBoxTimkiem_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 16);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 11;
            label3.Text = "Tìm kiếm";
            label3.Click += label3_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(421, 6);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(98, 30);
            BtnDelete.TabIndex = 9;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(525, 6);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(98, 30);
            btnCapnhat.TabIndex = 8;
            btnCapnhat.Text = "Xác nhận trả";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // button2
            // 
            button2.Location = new Point(629, 6);
            button2.Name = "button2";
            button2.Size = new Size(98, 30);
            button2.TabIndex = 7;
            button2.Text = "Xem chi tiết";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(733, 6);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(98, 30);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "Thêm";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // DataMuon
            // 
            DataMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataMuon.Columns.AddRange(new DataGridViewColumn[] { Maphieumuon, Ngaymuon, Ngaytra, Mathanhvien, Trangthai });
            DataMuon.Location = new Point(3, 57);
            DataMuon.Name = "DataMuon";
            DataMuon.Size = new Size(831, 472);
            DataMuon.TabIndex = 0;
            DataMuon.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Maphieumuon
            // 
            Maphieumuon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Maphieumuon.DataPropertyName = "Maphieumuon";
            Maphieumuon.FillWeight = 63.45178F;
            Maphieumuon.HeaderText = "ID";
            Maphieumuon.Name = "Maphieumuon";
            Maphieumuon.ReadOnly = true;
            Maphieumuon.Resizable = DataGridViewTriState.False;
            // 
            // Ngaymuon
            // 
            Ngaymuon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ngaymuon.DataPropertyName = "Ngaymuon";
            Ngaymuon.FillWeight = 109.137047F;
            Ngaymuon.HeaderText = "Ngày mượn";
            Ngaymuon.Name = "Ngaymuon";
            Ngaymuon.ReadOnly = true;
            Ngaymuon.Resizable = DataGridViewTriState.False;
            // 
            // Ngaytra
            // 
            Ngaytra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ngaytra.DataPropertyName = "Ngaytra";
            Ngaytra.FillWeight = 109.137047F;
            Ngaytra.HeaderText = "Ngày trả dự kiến";
            Ngaytra.Name = "Ngaytra";
            Ngaytra.ReadOnly = true;
            Ngaytra.Resizable = DataGridViewTriState.False;
            // 
            // Mathanhvien
            // 
            Mathanhvien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mathanhvien.DataPropertyName = "Mathanhvien";
            Mathanhvien.FillWeight = 109.137047F;
            Mathanhvien.HeaderText = "Mã thành vên";
            Mathanhvien.Name = "Mathanhvien";
            Mathanhvien.ReadOnly = true;
            Mathanhvien.Resizable = DataGridViewTriState.False;
            // 
            // Trangthai
            // 
            Trangthai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Trangthai.DataPropertyName = "Trangthai";
            Trangthai.FillWeight = 109.137047F;
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.Name = "Trangthai";
            Trangthai.ReadOnly = true;
            Trangthai.Resizable = DataGridViewTriState.False;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxTimkiemtra);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataTra);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(837, 532);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh sách trả";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(733, 6);
            button1.Name = "button1";
            button1.Size = new Size(98, 30);
            button1.TabIndex = 8;
            button1.Text = "Xem chi tiết";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataTra
            // 
            dataTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTra.Columns.AddRange(new DataGridViewColumn[] { Maphieumuon1, Ngaymuon1, Ngaytra1, Mathanhvien1, Trangthai1 });
            dataTra.Location = new Point(3, 42);
            dataTra.Name = "dataTra";
            dataTra.Size = new Size(831, 475);
            dataTra.TabIndex = 1;
            dataTra.CellContentClick += dataTra_CellContentClick;
            // 
            // Maphieumuon1
            // 
            Maphieumuon1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Maphieumuon1.DataPropertyName = "Maphieumuon";
            Maphieumuon1.HeaderText = "ID";
            Maphieumuon1.Name = "Maphieumuon1";
            // 
            // Ngaymuon1
            // 
            Ngaymuon1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ngaymuon1.DataPropertyName = "Ngaymuon";
            Ngaymuon1.HeaderText = "Ngày mượn";
            Ngaymuon1.Name = "Ngaymuon1";
            // 
            // Ngaytra1
            // 
            Ngaytra1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ngaytra1.DataPropertyName = "Ngaytra";
            Ngaytra1.HeaderText = "Ngày trả dự kiến";
            Ngaytra1.Name = "Ngaytra1";
            // 
            // Mathanhvien1
            // 
            Mathanhvien1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mathanhvien1.DataPropertyName = "Mathanhvien";
            Mathanhvien1.HeaderText = "Mã thành vên";
            Mathanhvien1.Name = "Mathanhvien1";
            // 
            // Trangthai1
            // 
            Trangthai1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Trangthai1.DataPropertyName = "Trangthai";
            Trangthai1.HeaderText = "Trạng thái";
            Trangthai1.Name = "Trangthai1";
            // 
            // textBoxTimkiemtra
            // 
            textBoxTimkiemtra.Location = new Point(163, 11);
            textBoxTimkiemtra.Name = "textBoxTimkiemtra";
            textBoxTimkiemtra.Size = new Size(175, 23);
            textBoxTimkiemtra.TabIndex = 14;
            textBoxTimkiemtra.TextChanged += textBoxTimkiemtra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 12);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 13;
            label2.Text = "Tìm kiếm";
            // 
            // Muontra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Muontra";
            Size = new Size(945, 675);
            Load += Muontra_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataMuon).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataTra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView DataMuon;
        private TabPage tabPage2;
        private DataGridView dataTra;
        private Button BtnDelete;
        private Button btnCapnhat;
        private Button button2;
        private Button BtnAdd;
        private Label label3;
        private Button button1;
        private TextBox TextBoxTimkiem;
        private DataGridViewTextBoxColumn Maphieumuon;
        private DataGridViewTextBoxColumn Ngaymuon;
        private DataGridViewTextBoxColumn Ngaytra;
        private DataGridViewTextBoxColumn Mathanhvien;
        private DataGridViewTextBoxColumn Trangthai;
        private DataGridViewTextBoxColumn Maphieumuon1;
        private DataGridViewTextBoxColumn Ngaymuon1;
        private DataGridViewTextBoxColumn Ngaytra1;
        private DataGridViewTextBoxColumn Mathanhvien1;
        private DataGridViewTextBoxColumn Trangthai1;
        private TextBox textBoxTimkiemtra;
        private Label label2;
    }
}
