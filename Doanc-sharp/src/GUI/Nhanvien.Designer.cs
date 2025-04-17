namespace Doanc_sharp
{
    partial class Nhanvien
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
            panel1 = new Panel();
            DataNhanvien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Account = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Chucvu = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataNhanvien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(143, 36);
            label1.TabIndex = 7;
            label1.Text = "Nhân viên";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.BackgroundImage = Properties.Resources.plus_icon;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(867, 22);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 38);
            panel1.TabIndex = 5;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // DataNhanvien
            // 
            DataNhanvien.BackgroundColor = SystemColors.ControlLightLight;
            DataNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataNhanvien.Columns.AddRange(new DataGridViewColumn[] { ID, Ten, phone, Address, Account, Password, Email, Chucvu, Trangthai });
            DataNhanvien.Location = new Point(24, 75);
            DataNhanvien.Margin = new Padding(3, 2, 3, 2);
            DataNhanvien.Name = "DataNhanvien";
            DataNhanvien.RowHeadersWidth = 51;
            DataNhanvien.Size = new Size(908, 598);
            DataNhanvien.TabIndex = 6;
            DataNhanvien.CellContentClick += dataGridView1_CellContentClick;
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
            // Chucvu
            // 
            Chucvu.HeaderText = "Chức vụ";
            Chucvu.Name = "Chucvu";
            Chucvu.Width = 80;
            // 
            // Trangthai
            // 
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 80;
            // 
            // Nhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(label1);
            Controls.Add(DataNhanvien);
            Controls.Add(panel1);
            Name = "Nhanvien";
            Size = new Size(945, 675);
            Load += Nhanvien_Load;
            ((System.ComponentModel.ISupportInitialize)DataNhanvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView DataNhanvien;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Chucvu;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
