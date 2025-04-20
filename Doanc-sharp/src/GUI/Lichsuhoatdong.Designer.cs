namespace Doanc_sharp
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
            ID = new DataGridViewTextBoxColumn();
            Thanhvien = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            Chitiet = new DataGridViewTextBoxColumn();
            Thoigian = new DataGridViewTextBoxColumn();
            label1 = new Label();
            FindTbx = new TextBox();
            FindBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
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
            FindTbx.Font = new Font("Segoe UI", 14F);
            FindTbx.ForeColor = SystemColors.ScrollBar;
            FindTbx.Location = new Point(3, 2);
            FindTbx.Margin = new Padding(3, 2, 0, 2);
            FindTbx.Name = "FindTbx";
            FindTbx.Size = new Size(282, 32);
            FindTbx.TabIndex = 7;
            FindTbx.Text = "Tìm kiếm...";
            FindTbx.Enter += onFocus;
            FindTbx.KeyPress += checkEnter;
            FindTbx.Leave += onBlur;
            // 
            // FindBtn
            // 
            FindBtn.Anchor = AnchorStyles.Right;
            FindBtn.BackgroundImage = Properties.Resources.findIcon;
            FindBtn.Location = new Point(285, 2);
            FindBtn.Margin = new Padding(0, 2, 0, 2);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(32, 32);
            FindBtn.TabIndex = 8;
            FindBtn.UseVisualStyleBackColor = true;
            FindBtn.MouseClick += onClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(FindTbx);
            flowLayoutPanel1.Controls.Add(FindBtn);
            flowLayoutPanel1.Location = new Point(600, 22);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(318, 35);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Lichsuhoatdong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lichsuhoatdong";
            Size = new Size(945, 675);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
