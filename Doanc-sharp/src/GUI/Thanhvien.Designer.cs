namespace Doanc_sharp
{
    partial class Thanhvien
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
            Label label1;
            DataThanhvien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Account = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Ngay = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnExcel = new Button();
            btnCapnhat = new Button();
            btnReset = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataThanhvien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 12);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 10;
            label1.Text = "Thành viên";
            // 
            // DataThanhvien
            // 
            DataThanhvien.BackgroundColor = SystemColors.ControlLightLight;
            DataThanhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataThanhvien.Columns.AddRange(new DataGridViewColumn[] { ID, Ten, phone, Address, Account, Password, Email, Ngay, Trangthai });
            DataThanhvien.Location = new Point(3, 59);
            DataThanhvien.Margin = new Padding(3, 2, 3, 2);
            DataThanhvien.Name = "DataThanhvien";
            DataThanhvien.RowHeadersWidth = 51;
            DataThanhvien.Size = new Size(908, 598);
            DataThanhvien.TabIndex = 9;
            DataThanhvien.CellContentClick += DataThanhvien_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "Mathanhvien";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Resizable = DataGridViewTriState.False;
            // 
            // Ten
            // 
            Ten.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ten.DataPropertyName = "Hoten";
            Ten.HeaderText = "Họ tên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.Resizable = DataGridViewTriState.False;
            // 
            // phone
            // 
            phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone.DataPropertyName = "Sdt";
            phone.HeaderText = "SDT";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Resizable = DataGridViewTriState.False;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "Diachi";
            Address.HeaderText = "Địa chỉ";
            Address.Name = "Address";
            Address.Resizable = DataGridViewTriState.False;
            // 
            // Account
            // 
            Account.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Account.DataPropertyName = "Taikhoan";
            Account.HeaderText = "Tài khoản";
            Account.Name = "Account";
            Account.Resizable = DataGridViewTriState.False;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "Matkhau";
            Password.HeaderText = "Mật khẩu";
            Password.Name = "Password";
            Password.Resizable = DataGridViewTriState.False;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Resizable = DataGridViewTriState.False;
            // 
            // Ngay
            // 
            Ngay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ngay.DataPropertyName = "Ngaydangky";
            Ngay.HeaderText = "Ngày tạo";
            Ngay.Name = "Ngay";
            Ngay.Resizable = DataGridViewTriState.False;
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
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.BackgroundImageLayout = ImageLayout.Zoom;
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.ControlLightLight;
            btnXoa.Location = new Point(709, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(67, 40);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Green;
            btnExcel.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcel.ForeColor = SystemColors.ControlLightLight;
            btnExcel.Location = new Point(793, 12);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(67, 40);
            btnExcel.TabIndex = 11;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.BackColor = Color.SkyBlue;
            btnCapnhat.BackgroundImageLayout = ImageLayout.Zoom;
            btnCapnhat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapnhat.ForeColor = SystemColors.ControlLightLight;
            btnCapnhat.Location = new Point(612, 14);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(81, 40);
            btnCapnhat.TabIndex = 11;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DarkOrchid;
            btnReset.BackgroundImageLayout = ImageLayout.Zoom;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(872, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(54, 40);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Thanhvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(btnReset);
            Controls.Add(btnExcel);
            Controls.Add(btnXoa);
            Controls.Add(btnCapnhat);
            Controls.Add(label1);
            Controls.Add(DataThanhvien);
            Name = "Thanhvien";
            Size = new Size(945, 675);
            Load += Thanhvien_Load;
            ((System.ComponentModel.ISupportInitialize)DataThanhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataThanhvien;
        private Button btnXoa;
        private Button btnExcel;
        private Button btnCapnhat;
        private Button btnReset;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
