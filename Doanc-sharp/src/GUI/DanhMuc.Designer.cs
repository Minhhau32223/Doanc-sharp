namespace Doanc_sharp
{
    partial class DanhMuc
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
            DataDanhMuc = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            EditBtn = new Button();
            ID = new DataGridViewTextBoxColumn();
            Tendanhmuc = new DataGridViewTextBoxColumn();
            Mota = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // DataDanhMuc
            // 
            DataDanhMuc.BackgroundColor = SystemColors.ControlLightLight;
            DataDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDanhMuc.Columns.AddRange(new DataGridViewColumn[] { ID, Tendanhmuc, Mota });
            DataDanhMuc.Location = new Point(31, 62);
            DataDanhMuc.Margin = new Padding(3, 2, 3, 2);
            DataDanhMuc.Name = "DataDanhMuc";
            DataDanhMuc.RowHeadersWidth = 51;
            DataDanhMuc.Size = new Size(887, 560);
            DataDanhMuc.TabIndex = 5;
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
            panel1.MouseClick += panel1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(239, 36);
            label1.TabIndex = 3;
            label1.Text = "Danh mục thiết bị";
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Segoe UI", 22F);
            EditBtn.Location = new Point(743, 626);
            EditBtn.Margin = new Padding(3, 2, 3, 2);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(175, 45);
            EditBtn.TabIndex = 6;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "Madanhmuc";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // Tendanhmuc
            // 
            Tendanhmuc.DataPropertyName = "Tendanhmuc";
            Tendanhmuc.HeaderText = "Tên danh mục";
            Tendanhmuc.MinimumWidth = 6;
            Tendanhmuc.Name = "Tendanhmuc";
            Tendanhmuc.ReadOnly = true;
            Tendanhmuc.Width = 350;
            // 
            // Mota
            // 
            Mota.DataPropertyName = "Mota";
            Mota.HeaderText = "Mô tả";
            Mota.MinimumWidth = 6;
            Mota.Name = "Mota";
            Mota.ReadOnly = true;
            Mota.Width = 460;
            // 
            // DanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(DataDanhMuc);
            Controls.Add(EditBtn);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DanhMuc";
            Size = new Size(945, 675);
            Load += DanhMuc_Load;
            ((System.ComponentModel.ISupportInitialize)DataDanhMuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataDanhMuc;
        private Panel panel1;
        private Label label1;
        private Button EditBtn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tendanhmuc;
        private DataGridViewTextBoxColumn Mota;
    }
}