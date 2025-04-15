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
            ID = new DataGridViewTextBoxColumn();
            Thanhvien = new DataGridViewTextBoxColumn();
            Tenvipham = new DataGridViewTextBoxColumn();
            Mota = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            XulyBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Thanhvien, Tenvipham, Mota, Trangthai });
            dataGridView1.Location = new Point(35, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1014, 753);
            dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.BackgroundImage = Properties.Resources.plus_icon;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(1009, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 21);
            label1.Name = "label1";
            label1.Size = new Size(287, 46);
            label1.TabIndex = 3;
            label1.Text = "Quản lý vi phạm";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Thanhvien
            // 
            Thanhvien.HeaderText = "Thành viên";
            Thanhvien.MinimumWidth = 6;
            Thanhvien.Name = "Thanhvien";
            Thanhvien.Width = 185;
            // 
            // Tenvipham
            // 
            Tenvipham.HeaderText = "Tên vi phạm";
            Tenvipham.MinimumWidth = 6;
            Tenvipham.Name = "Tenvipham";
            Tenvipham.Width = 200;
            // 
            // Mota
            // 
            Mota.HeaderText = "Mô tả";
            Mota.MinimumWidth = 6;
            Mota.Name = "Mota";
            Mota.Width = 350;
            // 
            // Trangthai
            // 
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 125;
            // 
            // XulyBtn
            // 
            XulyBtn.Font = new Font("Segoe UI", 15F);
            XulyBtn.Location = new Point(868, 841);
            XulyBtn.Name = "XulyBtn";
            XulyBtn.Size = new Size(181, 56);
            XulyBtn.TabIndex = 6;
            XulyBtn.Text = "Xử lý vi phạm";
            XulyBtn.UseVisualStyleBackColor = true;
            // 
            // Vipham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(XulyBtn);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Vipham";
            Size = new Size(1080, 900);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Thanhvien;
        private DataGridViewTextBoxColumn Tenvipham;
        private DataGridViewTextBoxColumn Mota;
        private DataGridViewTextBoxColumn Trangthai;
        private Button XulyBtn;
    }
}
