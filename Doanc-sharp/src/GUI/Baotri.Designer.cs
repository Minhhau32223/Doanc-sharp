namespace Doanc_sharp
{
    partial class Baotri
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
            Ten_ThietBi = new DataGridViewTextBoxColumn();
            Nhanvien = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            Ngayyeucau = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Ten_ThietBi, Nhanvien, Trangthai, Ngayyeucau });
            dataGridView1.Location = new Point(35, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1014, 798);
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
           
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(128, 46);
            label1.TabIndex = 3;
            label1.Text = "Bảo trì";
            
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Ten_ThietBi
            // 
            Ten_ThietBi.HeaderText = "Tên thiết bị";
            Ten_ThietBi.MinimumWidth = 6;
            Ten_ThietBi.Name = "Ten_ThietBi";
            Ten_ThietBi.Width = 250;
            // 
            // Nhanvien
            // 
            Nhanvien.HeaderText = "Nhân viên";
            Nhanvien.MinimumWidth = 6;
            Nhanvien.Name = "Nhanvien";
            Nhanvien.Width = 200;
            // 
            // Trangthai
            // 
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 200;
            // 
            // Ngayyeucau
            // 
            Ngayyeucau.HeaderText = "Ngày yêu cầu";
            Ngayyeucau.MinimumWidth = 6;
            Ngayyeucau.Name = "Ngayyeucau";
            Ngayyeucau.Width = 200;
            // 
            // Baotri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Baotri";
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
        private DataGridViewTextBoxColumn Ten_ThietBi;
        private DataGridViewTextBoxColumn Nhanvien;
        private DataGridViewTextBoxColumn Trangthai;
        private DataGridViewTextBoxColumn Ngayyeucau;
    }
}
