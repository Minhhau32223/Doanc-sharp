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
            DataMuon = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Ngaymuon = new DataGridViewTextBoxColumn();
            Ngaytradukien = new DataGridViewTextBoxColumn();
            Matv = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            BtnDelete = new Button();
            btnCapnhat = new Button();
            button2 = new Button();
            BtnAdd = new Button();
            button1 = new Button();
            label3 = new Label();
            TextBoxTimkiem = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataMuon).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // DataMuon
            // 
            DataMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataMuon.Columns.AddRange(new DataGridViewColumn[] { ID, Ngaymuon, Ngaytradukien, Matv, Trangthai });
            DataMuon.Location = new Point(3, 57);
            DataMuon.Name = "DataMuon";
            DataMuon.Size = new Size(831, 472);
            DataMuon.TabIndex = 0;
            DataMuon.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Ngaymuon
            // 
            Ngaymuon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ngaymuon.HeaderText = "Ngày mượn";
            Ngaymuon.Name = "Ngaymuon";
            // 
            // Ngaytradukien
            // 
            Ngaytradukien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ngaytradukien.HeaderText = "Ngày trả dự kiến";
            Ngaytradukien.Name = "Ngaytradukien";
            // 
            // Matv
            // 
            Matv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Matv.HeaderText = "Mã thành vên";
            Matv.Name = "Matv";
            // 
            // Trangthai
            // 
            Trangthai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.Name = "Trangthai";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(837, 532);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh sách trả";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.Location = new Point(10, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(831, 475);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Ngày mượn";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Ngày trả dự kiến";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Mã thành vên";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Trạng thái";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(421, 6);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(98, 30);
            BtnDelete.TabIndex = 9;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(525, 6);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(98, 30);
            btnCapnhat.TabIndex = 8;
            btnCapnhat.Text = "Cập nhật ";
            btnCapnhat.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(629, 6);
            button2.Name = "button2";
            button2.Size = new Size(98, 30);
            button2.TabIndex = 7;
            button2.Text = "Xem chi tiết";
            button2.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Location = new Point(733, 6);
            button1.Name = "button1";
            button1.Size = new Size(98, 30);
            button1.TabIndex = 8;
            button1.Text = "Xem chi tiết";
            button1.UseVisualStyleBackColor = true;
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
            // TextBoxTimkiem
            // 
            TextBoxTimkiem.Location = new Point(135, 15);
            TextBoxTimkiem.Name = "TextBoxTimkiem";
            TextBoxTimkiem.Size = new Size(175, 23);
            TextBoxTimkiem.TabIndex = 12;
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataMuon).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView DataMuon;
        private TabPage tabPage2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ngaymuon;
        private DataGridViewTextBoxColumn Ngaytradukien;
        private DataGridViewTextBoxColumn Matv;
        private DataGridViewTextBoxColumn Trangthai;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button BtnDelete;
        private Button btnCapnhat;
        private Button button2;
        private Button BtnAdd;
        private Label label3;
        private Button button1;
        private TextBox TextBoxTimkiem;
    }
}
