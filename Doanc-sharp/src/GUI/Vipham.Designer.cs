namespace Doanc_sharp
{
    partial class Vipham
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
            panel1 = new Panel();
            label1 = new Label();
            XulyBtn = new Button();
            ID = new DataGridViewTextBoxColumn();
            Thanhvien = new DataGridViewTextBoxColumn();
            Tenvipham = new DataGridViewTextBoxColumn();
            Mota = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Thanhvien, Tenvipham, Mota, Trangthai });
            dataGridView1.Location = new Point(31, 62);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(887, 565);
            dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.BackgroundImage = Properties.Resources.plus_icon;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(874, 20);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 38);
            panel1.TabIndex = 4;
            panel1.MouseClick += onClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(222, 36);
            label1.TabIndex = 3;
            label1.Text = "Quản lý vi phạm";
            // 
            // XulyBtn
            // 
            XulyBtn.Font = new Font("Segoe UI", 15F);
            XulyBtn.Location = new Point(760, 631);
            XulyBtn.Margin = new Padding(3, 2, 3, 2);
            XulyBtn.Name = "XulyBtn";
            XulyBtn.Size = new Size(158, 42);
            XulyBtn.TabIndex = 6;
            XulyBtn.Text = "Xử lý vi phạm";
            XulyBtn.UseVisualStyleBackColor = true;
            XulyBtn.Click += XulyBtn_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "Mavipham";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Thanhvien
            // 
            Thanhvien.DataPropertyName = "Hoten";
            Thanhvien.HeaderText = "Thành viên";
            Thanhvien.MinimumWidth = 6;
            Thanhvien.Name = "Thanhvien";
            Thanhvien.Width = 185;
            // 
            // Tenvipham
            // 
            Tenvipham.DataPropertyName = "Tenvipham";
            Tenvipham.HeaderText = "Tên vi phạm";
            Tenvipham.MinimumWidth = 6;
            Tenvipham.Name = "Tenvipham";
            Tenvipham.Width = 200;
            // 
            // Mota
            // 
            Mota.DataPropertyName = "Mota";
            Mota.HeaderText = "Mô tả";
            Mota.MinimumWidth = 6;
            Mota.Name = "Mota";
            Mota.Width = 250;
            // 
            // Trangthai
            // 
            Trangthai.DataPropertyName = "Trangthai";
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 125;
            // 
            // Vipham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(XulyBtn);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Vipham";
            Size = new Size(945, 675);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button XulyBtn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Thanhvien;
        private DataGridViewTextBoxColumn Tenvipham;
        private DataGridViewTextBoxColumn Mota;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
