﻿namespace Doanc_sharp
{
    partial class Lichsuhoatdong
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            FindTbx = new TextBox();
            FindBtn = new Button();
            ID = new DataGridViewTextBoxColumn();
            Thanhvien = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            Chitiet = new DataGridViewTextBoxColumn();
            Thoigian = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Thanhvien, Loai, Chitiet, Thoigian });
            dataGridView1.Location = new Point(31, 62);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(887, 599);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(377, 36);
            label1.TabIndex = 3;
            label1.Text = "Lịch sử hoạt động thành viên";
            // 
            // FindTbx
            // 
            FindTbx.ForeColor = SystemColors.ScrollBar;
            FindTbx.Location = new Point(728, 32);
            FindTbx.Margin = new Padding(3, 2, 3, 2);
            FindTbx.Name = "FindTbx";
            FindTbx.Size = new Size(190, 23);
            FindTbx.TabIndex = 7;
            FindTbx.Text = "Tìm kiếm...";
            // 
            // FindBtn
            // 
            FindBtn.BackgroundImage = Properties.Resources.findIcon;
            FindBtn.Location = new Point(886, 32);
            FindBtn.Margin = new Padding(3, 2, 3, 2);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(32, 22);
            FindBtn.TabIndex = 8;
            FindBtn.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.DataPropertyName = "Mahoatdong";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Thanhvien
            // 
            Thanhvien.DataPropertyName = "Mathanhvien";
            Thanhvien.HeaderText = "Thành viên";
            Thanhvien.MinimumWidth = 6;
            Thanhvien.Name = "Thanhvien";
            Thanhvien.Width = 185;
            // 
            // Loai
            // 
            Loai.DataPropertyName = "Loai";
            Loai.HeaderText = "Loại";
            Loai.MinimumWidth = 6;
            Loai.Name = "Loai";
            Loai.Width = 150;
            // 
            // Chitiet
            // 
            Chitiet.DataPropertyName = "Chitiet";
            Chitiet.HeaderText = "Chi tiết";
            Chitiet.MinimumWidth = 6;
            Chitiet.Name = "Chitiet";
            Chitiet.Width = 250;
            // 
            // Thoigian
            // 
            Thoigian.DataPropertyName = "Thoigian";
            Thoigian.HeaderText = "Thời gian";
            Thoigian.MinimumWidth = 6;
            Thoigian.Name = "Thoigian";
            Thoigian.Width = 200;
            // 
            // Lichsuhoatdong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(FindBtn);
            Controls.Add(FindTbx);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lichsuhoatdong";
            Size = new Size(945, 675);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox FindTbx;
        private Button FindBtn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Thanhvien;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn Chitiet;
        private DataGridViewTextBoxColumn Thoigian;
    }
}
