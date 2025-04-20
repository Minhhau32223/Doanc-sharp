namespace Doanc_sharp
{
    partial class Themdanhmuc
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
            Motalbl = new Label();
            Tenlbl = new Label();
            XacnhanBtn = new Button();
            ThoatBtn = new Button();
            MotaTbx = new TextBox();
            TenTbx = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 71);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(257, 40);
            label1.TabIndex = 0;
            label1.Text = "Thêm danh mục";
            // 
            // Motalbl
            // 
            Motalbl.AutoSize = true;
            Motalbl.Font = new Font("Times New Roman", 13.8F);
            Motalbl.Location = new Point(148, 172);
            Motalbl.Name = "Motalbl";
            Motalbl.Size = new Size(58, 21);
            Motalbl.TabIndex = 25;
            Motalbl.Text = "Mô tả:";
            // 
            // Tenlbl
            // 
            Tenlbl.AutoSize = true;
            Tenlbl.Font = new Font("Times New Roman", 13.8F);
            Tenlbl.Location = new Point(148, 133);
            Tenlbl.Name = "Tenlbl";
            Tenlbl.Size = new Size(43, 21);
            Tenlbl.TabIndex = 26;
            Tenlbl.Text = "Tên:";
            // 
            // XacnhanBtn
            // 
            XacnhanBtn.BackColor = Color.Green;
            XacnhanBtn.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XacnhanBtn.ForeColor = SystemColors.ButtonHighlight;
            XacnhanBtn.Location = new Point(396, 272);
            XacnhanBtn.Margin = new Padding(3, 2, 3, 2);
            XacnhanBtn.Name = "XacnhanBtn";
            XacnhanBtn.Size = new Size(218, 52);
            XacnhanBtn.TabIndex = 21;
            XacnhanBtn.Text = "Xác nhận";
            XacnhanBtn.UseVisualStyleBackColor = false;
            XacnhanBtn.Click += XacnhanBtn_Click;
            // 
            // ThoatBtn
            // 
            ThoatBtn.BackColor = Color.Red;
            ThoatBtn.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThoatBtn.ForeColor = SystemColors.ButtonHighlight;
            ThoatBtn.Location = new Point(91, 272);
            ThoatBtn.Margin = new Padding(3, 2, 3, 2);
            ThoatBtn.Name = "ThoatBtn";
            ThoatBtn.Size = new Size(218, 52);
            ThoatBtn.TabIndex = 22;
            ThoatBtn.Text = "Thoát";
            ThoatBtn.UseVisualStyleBackColor = false;
            ThoatBtn.Click += ThoatBtn_Click;
            // 
            // MotaTbx
            // 
            MotaTbx.Location = new Point(242, 173);
            MotaTbx.Margin = new Padding(3, 2, 3, 2);
            MotaTbx.Name = "MotaTbx";
            MotaTbx.Size = new Size(297, 23);
            MotaTbx.TabIndex = 18;
            // 
            // TenTbx
            // 
            TenTbx.Location = new Point(242, 132);
            TenTbx.Margin = new Padding(3, 2, 3, 2);
            TenTbx.Name = "TenTbx";
            TenTbx.Size = new Size(297, 23);
            TenTbx.TabIndex = 19;
            // 
            // Themdanhmuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 377);
            Controls.Add(panel1);
            Controls.Add(Motalbl);
            Controls.Add(Tenlbl);
            Controls.Add(XacnhanBtn);
            Controls.Add(ThoatBtn);
            Controls.Add(MotaTbx);
            Controls.Add(TenTbx);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Themdanhmuc";
            Text = "Thêm danh mục";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label Motalbl;
        private Label Tenlbl;
        private Button XacnhanBtn;
        private Button ThoatBtn;
        private TextBox textBox3;
        private TextBox MotaTbx;
        private TextBox TenTbx;
    }
}