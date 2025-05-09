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
            Ngayvp = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Thanhvien, Tenvipham, Mota, Ngayvp, Trangthai });
            dataGridView1.Location = new Point(31, 62);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(887, 565);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.DataPropertyName = "Mavipham";
            ID.FillWeight = 376.2886F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 100;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            // 
            // Thanhvien
            // 
            Thanhvien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Thanhvien.DataPropertyName = "Hoten";
            Thanhvien.FillWeight = 30.92784F;
            Thanhvien.HeaderText = "Thành viên";
            Thanhvien.MinimumWidth = 150;
            Thanhvien.Name = "Thanhvien";
            Thanhvien.Resizable = DataGridViewTriState.False;
            Thanhvien.Width = 150;
            // 
            // Tenvipham
            // 
            Tenvipham.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tenvipham.DataPropertyName = "Tenvipham";
            Tenvipham.FillWeight = 30.92784F;
            Tenvipham.HeaderText = "Tên vi phạm";
            Tenvipham.MinimumWidth = 150;
            Tenvipham.Name = "Tenvipham";
            Tenvipham.Resizable = DataGridViewTriState.False;
            Tenvipham.Width = 150;
            // 
            // Mota
            // 
            Mota.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Mota.DataPropertyName = "Mota";
            Mota.FillWeight = 30.92784F;
            Mota.HeaderText = "Mô tả";
            Mota.MinimumWidth = 200;
            Mota.Name = "Mota";
            Mota.Width = 200;
            // 
            // Ngayvp
            // 
            Ngayvp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Ngayvp.DataPropertyName = "Ngayvp";
            Ngayvp.HeaderText = "Ngày vi phạm";
            Ngayvp.MinimumWidth = 100;
            Ngayvp.Name = "Ngayvp";
            Ngayvp.Width = 106;
            // 
            // Trangthai
            // 
            Trangthai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Trangthai.DataPropertyName = "Trangthai";
            Trangthai.FillWeight = 30.92784F;
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 85;
            Trangthai.Name = "Trangthai";
            Trangthai.Resizable = DataGridViewTriState.False;
            Trangthai.Width = 85;
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
        private DataGridViewTextBoxColumn Ngayvp;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
