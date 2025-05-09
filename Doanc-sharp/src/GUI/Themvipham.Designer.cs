namespace Doanc_sharp
{
    partial class Themvipham
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
            label3 = new Label();
            label2 = new Label();
            XacnhanBtn = new Button();
            ThoatBtn = new Button();
            TvvpCbx = new ComboBox();
            ViPhamCbx = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tenVPTbx = new TextBox();
            moTaTbx = new TextBox();
            TVPChb = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 95);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(291, 51);
            label1.TabIndex = 0;
            label1.Text = "Thêm vi phạm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(104, 179);
            label3.Name = "label3";
            label3.Size = new Size(97, 26);
            label3.TabIndex = 25;
            label3.Text = "Vi phạm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(104, 129);
            label2.Name = "label2";
            label2.Size = new Size(206, 26);
            label2.TabIndex = 26;
            label2.Text = "Thành viên vi phạm:";
            // 
            // XacnhanBtn
            // 
            XacnhanBtn.BackColor = Color.Green;
            XacnhanBtn.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XacnhanBtn.ForeColor = SystemColors.ButtonHighlight;
            XacnhanBtn.Location = new Point(453, 363);
            XacnhanBtn.Name = "XacnhanBtn";
            XacnhanBtn.Size = new Size(249, 69);
            XacnhanBtn.TabIndex = 21;
            XacnhanBtn.Text = "&Xác nhận";
            XacnhanBtn.UseVisualStyleBackColor = false;
            XacnhanBtn.Click += XacnhanBtn_Click;
            // 
            // ThoatBtn
            // 
            ThoatBtn.BackColor = Color.Red;
            ThoatBtn.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThoatBtn.ForeColor = SystemColors.ButtonHighlight;
            ThoatBtn.Location = new Point(104, 363);
            ThoatBtn.Name = "ThoatBtn";
            ThoatBtn.Size = new Size(249, 69);
            ThoatBtn.TabIndex = 22;
            ThoatBtn.Text = "&Thoát";
            ThoatBtn.UseVisualStyleBackColor = false;
            ThoatBtn.Click += ThoatBtn_Click;
            // 
            // TvvpCbx
            // 
            TvvpCbx.FormattingEnabled = true;
            TvvpCbx.Location = new Point(362, 131);
            TvvpCbx.Name = "TvvpCbx";
            TvvpCbx.Size = new Size(339, 28);
            TvvpCbx.TabIndex = 27;
            // 
            // ViPhamCbx
            // 
            ViPhamCbx.FormattingEnabled = true;
            ViPhamCbx.Location = new Point(362, 180);
            ViPhamCbx.Name = "ViPhamCbx";
            ViPhamCbx.Size = new Size(339, 28);
            ViPhamCbx.TabIndex = 28;
            ViPhamCbx.SelectedIndexChanged += onChange;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(104, 249);
            label4.Name = "label4";
            label4.Size = new Size(136, 26);
            label4.TabIndex = 29;
            label4.Text = "Tên vi phạm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(104, 299);
            label5.Name = "label5";
            label5.Size = new Size(71, 26);
            label5.TabIndex = 30;
            label5.Text = "Mô tả:";
            // 
            // tenVPTbx
            // 
            tenVPTbx.Enabled = false;
            tenVPTbx.Location = new Point(362, 251);
            tenVPTbx.Margin = new Padding(3, 4, 3, 4);
            tenVPTbx.Name = "tenVPTbx";
            tenVPTbx.Size = new Size(339, 27);
            tenVPTbx.TabIndex = 31;
            // 
            // moTaTbx
            // 
            moTaTbx.Enabled = false;
            moTaTbx.Location = new Point(362, 300);
            moTaTbx.Margin = new Padding(3, 4, 3, 4);
            moTaTbx.Name = "moTaTbx";
            moTaTbx.Size = new Size(339, 27);
            moTaTbx.TabIndex = 32;
            // 
            // TVPChb
            // 
            TVPChb.AutoSize = true;
            TVPChb.Location = new Point(104, 222);
            TVPChb.Name = "TVPChb";
            TVPChb.Size = new Size(191, 24);
            TVPChb.TabIndex = 33;
            TVPChb.Text = "Hoặc thêm vi phạm mới";
            TVPChb.UseVisualStyleBackColor = true;
            TVPChb.CheckedChanged += onCheck;
            // 
            // Themvipham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 503);
            Controls.Add(TVPChb);
            Controls.Add(moTaTbx);
            Controls.Add(tenVPTbx);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ViPhamCbx);
            Controls.Add(TvvpCbx);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(XacnhanBtn);
            Controls.Add(ThoatBtn);
            Name = "Themvipham";
            Text = "Thêm vi phạm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button XacnhanBtn;
        private Button ThoatBtn;
        private ComboBox TvvpCbx;
        private ComboBox ViPhamCbx;
        private Label label4;
        private Label label5;
        private TextBox tenVPTbx;
        private TextBox moTaTbx;
        private CheckBox TVPChb;
    }
}