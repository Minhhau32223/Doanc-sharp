namespace Doanc_sharp
{
    partial class Xulyvipham
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
            TrangthaiCbx = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            XulyBtn = new Button();
            ThoatBtn = new Button();
            MotaTbx = new TextBox();
            TenvpTbx = new TextBox();
            TvvpCbx = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TrangthaiCbx
            // 
            TrangthaiCbx.FormattingEnabled = true;
            TrangthaiCbx.Items.AddRange(new object[] { "Chưa xử lý", "Đã xử lý" });
            TrangthaiCbx.Location = new Point(317, 207);
            TrangthaiCbx.Margin = new Padding(3, 2, 3, 2);
            TrangthaiCbx.Name = "TrangthaiCbx";
            TrangthaiCbx.Size = new Size(297, 23);
            TrangthaiCbx.TabIndex = 20;
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
            label1.Size = new Size(227, 40);
            label1.TabIndex = 0;
            label1.Text = "Xử lý vi phạm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(91, 208);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 23;
            label5.Text = "Trạng thái:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(91, 170);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 24;
            label4.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(91, 134);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 25;
            label3.Text = "Tên vi phạm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(91, 97);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 26;
            label2.Text = "Thành viên vi phạm:";
            // 
            // XulyBtn
            // 
            XulyBtn.BackColor = Color.Green;
            XulyBtn.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XulyBtn.ForeColor = SystemColors.ButtonHighlight;
            XulyBtn.Location = new Point(396, 272);
            XulyBtn.Margin = new Padding(3, 2, 3, 2);
            XulyBtn.Name = "XulyBtn";
            XulyBtn.Size = new Size(218, 52);
            XulyBtn.TabIndex = 21;
            XulyBtn.Text = "Xử lý";
            XulyBtn.UseVisualStyleBackColor = false;
            XulyBtn.Click += XulyBtn_Click;
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
            MotaTbx.Location = new Point(317, 170);
            MotaTbx.Margin = new Padding(3, 2, 3, 2);
            MotaTbx.Name = "MotaTbx";
            MotaTbx.Size = new Size(297, 23);
            MotaTbx.TabIndex = 17;
            // 
            // TenvpTbx
            // 
            TenvpTbx.Location = new Point(317, 134);
            TenvpTbx.Margin = new Padding(3, 2, 3, 2);
            TenvpTbx.Name = "TenvpTbx";
            TenvpTbx.Size = new Size(297, 23);
            TenvpTbx.TabIndex = 18;
            // 
            // TvvpCbx
            // 
            TvvpCbx.FormattingEnabled = true;
            TvvpCbx.Location = new Point(317, 98);
            TvvpCbx.Margin = new Padding(3, 2, 3, 2);
            TvvpCbx.Name = "TvvpCbx";
            TvvpCbx.Size = new Size(297, 23);
            TvvpCbx.TabIndex = 27;
            // 
            // Xulyvipham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 377);
            Controls.Add(TvvpCbx);
            Controls.Add(TrangthaiCbx);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(XulyBtn);
            Controls.Add(ThoatBtn);
            Controls.Add(MotaTbx);
            Controls.Add(TenvpTbx);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Xulyvipham";
            Text = "Xử lý vi phạm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TrangthaiCbx;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button XulyBtn;
        private Button ThoatBtn;
        private TextBox MotaTbx;
        private TextBox TenvpTbx;
        private ComboBox TvvpCbx;
    }
}