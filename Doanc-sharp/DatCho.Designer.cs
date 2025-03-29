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
            Ban = new DataGridViewTextBoxColumn();
            NgayDat = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tblDatCho).BeginInit();
            SuspendLayout();
            // 
            // tblDatCho
            // 
            tblDatCho.BackgroundColor = SystemColors.ControlLightLight;
            tblDatCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblDatCho.Columns.AddRange(new DataGridViewColumn[] { ID, Ban, NgayDat, Trangthai });
            tblDatCho.Location = new Point(35, 82);
            tblDatCho.Name = "tblDatCho";
            tblDatCho.RowHeadersWidth = 51;
            tblDatCho.Size = new Size(1014, 798);
            tblDatCho.TabIndex = 8;
            // 
            // pnThem
            // 
            pnThem.BackColor = Color.Green;
            pnThem.BackgroundImage = Properties.Resources.plus_icon;
            pnThem.BackgroundImageLayout = ImageLayout.Stretch;
            pnThem.Location = new Point(1009, 21);
            pnThem.Name = "pnThem";
            pnThem.Size = new Size(50, 50);
            pnThem.TabIndex = 7;
            // 
            // lblDatCho
            // 
            lblDatCho.AutoSize = true;
            lblDatCho.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatCho.Location = new Point(22, 21);
            lblDatCho.Name = "lblDatCho";
            lblDatCho.Size = new Size(144, 46);
            lblDatCho.TabIndex = 6;
            lblDatCho.Text = "Đặt chỗ";
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Ban
            // 
            Ban.HeaderText = "Bàn";
            Ban.MinimumWidth = 6;
            Ban.Name = "Ban";
            Ban.Width = 350;
            // 
            // NgayDat
            // 
            NgayDat.HeaderText = "Ngày đặt";
            NgayDat.MinimumWidth = 6;
            NgayDat.Name = "NgayDat";
            NgayDat.Width = 250;
            // 
            // Trangthai
            // 
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 250;
            // 
            // DatCho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(tblDatCho);
            Controls.Add(pnThem);
            Controls.Add(lblDatCho);
            Name = "DatCho";
            Size = new Size(1080, 900);
            ((System.ComponentModel.ISupportInitialize)tblDatCho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblDatCho;
        private Panel pnThem;
        private Label lblDatCho;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ban;
        private DataGridViewTextBoxColumn NgayDat;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
