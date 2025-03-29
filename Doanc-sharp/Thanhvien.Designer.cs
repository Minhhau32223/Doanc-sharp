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
            DataNhanvien = new DataGridView();
            panel1 = new Panel();
            ID = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Account = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Ngaydangky = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataNhanvien).BeginInit();
            SuspendLayout();
            // 
            // DataNhanvien
            // 
            DataNhanvien.BackgroundColor = SystemColors.ControlLightLight;
            DataNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataNhanvien.Columns.AddRange(new DataGridViewColumn[] { ID, Ten, phone, Address, Account, Password, Email, Ngaydangky, Trangthai });
            DataNhanvien.Location = new Point(18, 65);
            DataNhanvien.Margin = new Padding(3, 2, 3, 2);
            DataNhanvien.Name = "DataNhanvien";
            DataNhanvien.RowHeadersWidth = 51;
            DataNhanvien.Size = new Size(908, 598);
            DataNhanvien.TabIndex = 9;
            DataNhanvien.CellContentClick += DataNhanvien_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.BackgroundImage = Properties.Resources.plus_icon;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(861, 12);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 38);
            panel1.TabIndex = 8;
            panel1.Paint += this.panel1_Paint;
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
            label1.Click += this.label1_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 80;
            // 
            // Ten
            // 
            Ten.HeaderText = "Họ tên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.Width = 130;
            // 
            // phone
            // 
            phone.HeaderText = "SDT";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 80;
            // 
            // Address
            // 
            Address.HeaderText = "Địa chỉ";
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // Account
            // 
            Account.HeaderText = "Tài khoản";
            Account.Name = "Account";
            Account.Width = 80;
            // 
            // Password
            // 
            Password.HeaderText = "Mật khẩu";
            Password.Name = "Password";
            Password.Width = 80;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Ngaydangky
            // 
            Ngaydangky.HeaderText = "Ngày đăng ký";
            Ngaydangky.Name = "Ngaydangky";
            Ngaydangky.Width = 80;
            // 
            // Trangthai
            // 
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 80;
            // 
            // Thanhvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(DataNhanvien);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Thanhvien";
            Size = new Size(945, 675);
            ((System.ComponentModel.ISupportInitialize)DataNhanvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataNhanvien;
        private Panel panel1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Ngaydangky;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
