namespace Doanc_sharp
{
    partial class Thietbi
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
            dgvThietbi = new DataGridView();
            Mathietbi = new DataGridViewTextBoxColumn();
            TenThietBi = new DataGridViewTextBoxColumn();
            Giathue = new DataGridViewTextBoxColumn();
            Madanhmuc = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            btnCapnhat = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThietbi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 36);
            label1.TabIndex = 0;
            label1.Text = "Thiết bị";
            label1.Click += label1_Click;
            // 
            // dgvThietbi
            // 
            dgvThietbi.BackgroundColor = SystemColors.ControlLightLight;
            dgvThietbi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietbi.Columns.AddRange(new DataGridViewColumn[] { Mathietbi, TenThietBi, Giathue, Madanhmuc, Trangthai });
            dgvThietbi.Location = new Point(19, 56);
            dgvThietbi.Margin = new Padding(3, 2, 3, 2);
            dgvThietbi.Name = "dgvThietbi";
            dgvThietbi.RowHeadersWidth = 51;
            dgvThietbi.Size = new Size(887, 598);
            dgvThietbi.TabIndex = 2;
            dgvThietbi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Mathietbi
            // 
            Mathietbi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mathietbi.DataPropertyName = "Mathietbi";
            Mathietbi.HeaderText = "ID";
            Mathietbi.MinimumWidth = 6;
            Mathietbi.Name = "Mathietbi";
            Mathietbi.Resizable = DataGridViewTriState.False;
            // 
            // TenThietBi
            // 
            TenThietBi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenThietBi.DataPropertyName = "Tenthietbi";
            TenThietBi.HeaderText = "Tên thiết bị";
            TenThietBi.MinimumWidth = 6;
            TenThietBi.Name = "TenThietBi";
            // 
            // Giathue
            // 
            Giathue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Giathue.DataPropertyName = "Giathue";
            Giathue.HeaderText = "GIá";
            Giathue.MinimumWidth = 6;
            Giathue.Name = "Giathue";
            Giathue.Resizable = DataGridViewTriState.False;
            // 
            // Madanhmuc
            // 
            Madanhmuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Madanhmuc.DataPropertyName = "Madanhmuc";
            Madanhmuc.HeaderText = "Mã danh mục";
            Madanhmuc.Name = "Madanhmuc";
            Madanhmuc.Resizable = DataGridViewTriState.False;
            // 
            // Trangthai
            // 
            Trangthai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Trangthai.DataPropertyName = "Trangthai";
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Resizable = DataGridViewTriState.False;
            // 
            // btnCapnhat
            // 
            btnCapnhat.BackColor = Color.SkyBlue;
            btnCapnhat.BackgroundImageLayout = ImageLayout.Zoom;
            btnCapnhat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapnhat.ForeColor = SystemColors.ControlLightLight;
            btnCapnhat.Location = new Point(624, 10);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(81, 40);
            btnCapnhat.TabIndex = 12;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.BackgroundImageLayout = ImageLayout.Zoom;
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.ControlLightLight;
            btnXoa.Location = new Point(711, 11);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 40);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Purple;
            btnReset.BackgroundImageLayout = ImageLayout.Zoom;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(798, 11);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(81, 40);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Gold;
            btnThem.BackgroundImageLayout = ImageLayout.Zoom;
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ControlLightLight;
            btnThem.Location = new Point(537, 10);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(81, 40);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // Thietbi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(btnReset);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnCapnhat);
            Controls.Add(dgvThietbi);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Thietbi";
            Size = new Size(945, 675);
            Load += Thietbi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThietbi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvThietbi;
        private Button btnCapnhat;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private DataGridViewTextBoxColumn Mathietbi;
        private DataGridViewTextBoxColumn TenThietBi;
        private DataGridViewTextBoxColumn Giathue;
        private DataGridViewTextBoxColumn Madanhmuc;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
