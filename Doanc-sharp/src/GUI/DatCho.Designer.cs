namespace Doanc_sharp
{
    partial class DatCho
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
            tblDatCho = new DataGridView();
            pnThem = new Panel();
            lblDatCho = new Label();
            ID = new DataGridViewTextBoxColumn();
            Mathanhvien = new DataGridViewTextBoxColumn();
            NgayDat = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            btnXemct = new Button();
            ((System.ComponentModel.ISupportInitialize)tblDatCho).BeginInit();
            SuspendLayout();
            // 
            // tblDatCho
            // 
            tblDatCho.BackgroundColor = SystemColors.ControlLightLight;
            tblDatCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblDatCho.Columns.AddRange(new DataGridViewColumn[] { ID, Mathanhvien, NgayDat, Trangthai });
            tblDatCho.Location = new Point(31, 62);
            tblDatCho.Margin = new Padding(3, 2, 3, 2);
            tblDatCho.Name = "tblDatCho";
            tblDatCho.RowHeadersWidth = 51;
            tblDatCho.Size = new Size(887, 598);
            tblDatCho.TabIndex = 8;
            tblDatCho.CellContentClick += tblDatCho_CellContentClick;
            // 
            // pnThem
            // 
            pnThem.BackColor = Color.Green;
            pnThem.BackgroundImage = Properties.Resources.plus_icon;
            pnThem.BackgroundImageLayout = ImageLayout.Stretch;
            pnThem.Location = new Point(883, 16);
            pnThem.Margin = new Padding(3, 2, 3, 2);
            pnThem.Name = "pnThem";
            pnThem.Size = new Size(44, 38);
            pnThem.TabIndex = 7;
            // 
            // lblDatCho
            // 
            lblDatCho.AutoSize = true;
            lblDatCho.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatCho.Location = new Point(19, 16);
            lblDatCho.Name = "lblDatCho";
            lblDatCho.Size = new Size(114, 36);
            lblDatCho.TabIndex = 6;
            lblDatCho.Text = "Đặt chỗ";
            // 
            // ID
            // 
            ID.DataPropertyName = "Madatcho";
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Mathanhvien
            // 
            Mathanhvien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mathanhvien.DataPropertyName = "Mathanhvien";
            Mathanhvien.HeaderText = "Mã thành viên";
            Mathanhvien.MinimumWidth = 6;
            Mathanhvien.Name = "Mathanhvien";
            // 
            // NgayDat
            // 
            NgayDat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayDat.DataPropertyName = "Thoidatcho";
            NgayDat.HeaderText = "Ngày đặt";
            NgayDat.MinimumWidth = 6;
            NgayDat.Name = "NgayDat";
            // 
            // Trangthai
            // 
            Trangthai.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Trangthai.DataPropertyName = "Trangthai";
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 85;
            // 
            // btnXemct
            // 
            btnXemct.Location = new Point(721, 16);
            btnXemct.Name = "btnXemct";
            btnXemct.Size = new Size(132, 38);
            btnXemct.TabIndex = 9;
            btnXemct.Text = "Xem chi tiết";
            btnXemct.UseVisualStyleBackColor = true;
            btnXemct.Click += btnXemct_Click;
            // 
            // DatCho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(btnXemct);
            Controls.Add(tblDatCho);
            Controls.Add(pnThem);
            Controls.Add(lblDatCho);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DatCho";
            Size = new Size(945, 675);
            Load += DatCho_Load;
            ((System.ComponentModel.ISupportInitialize)tblDatCho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblDatCho;
        private Panel pnThem;
        private Label lblDatCho;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Mathanhvien;
        private DataGridViewTextBoxColumn NgayDat;
        private DataGridViewTextBoxColumn Trangthai;
        private Button btnXemct;
    }
}
