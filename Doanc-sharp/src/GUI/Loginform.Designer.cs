namespace Doanc_sharp
{
    partial class Loginform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThoat = new Button();
            btnDangnhap = new Button();
            accountTbox = new TextBox();
            passwordTbox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 83);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(259, 18);
            label1.Name = "label1";
            label1.Size = new Size(181, 40);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 110);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 27;
            label2.Text = "Tài khoản :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 179);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 27;
            label3.Text = "Mật khẩu :";
            label3.Click += label2_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(202, 257);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(209, 69);
            btnThoat.TabIndex = 28;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.Green;
            btnDangnhap.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangnhap.ForeColor = Color.White;
            btnDangnhap.Location = new Point(442, 257);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(209, 69);
            btnDangnhap.TabIndex = 28;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            // 
            // accountTbox
            // 
            accountTbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountTbox.Location = new Point(231, 102);
            accountTbox.Name = "accountTbox";
            accountTbox.Size = new Size(365, 35);
            accountTbox.TabIndex = 40;
            // 
            // passwordTbox
            // 
            passwordTbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTbox.Location = new Point(231, 171);
            passwordTbox.Name = "passwordTbox";
            passwordTbox.Size = new Size(365, 35);
            passwordTbox.TabIndex = 40;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(684, 361);
            ControlBox = false;
            Controls.Add(passwordTbox);
            Controls.Add(accountTbox);
            Controls.Add(btnDangnhap);
            Controls.Add(btnThoat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Loginform";
            Text = "Loginform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThoat;
        private Button btnDangnhap;
        private TextBox accountTbox;
        private TextBox passwordTbox;
    }
}