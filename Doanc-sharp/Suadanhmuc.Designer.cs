namespace Doanc_sharp
{
    partial class Suadanhmuc
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
            label1.Size = new Size(287, 51);
            label1.TabIndex = 0;
            label1.Text = "Sửa danh mục";
            // 
            // Motalbl
            // 
            Motalbl.AutoSize = true;
            Motalbl.Font = new Font("Times New Roman", 13.8F);
            Motalbl.Location = new Point(169, 230);
            Motalbl.Name = "Motalbl";
            Motalbl.Size = new Size(71, 26);
            Motalbl.TabIndex = 25;
            Motalbl.Text = "Mô tả:";
            // 
            // Tenlbl
            // 
            Tenlbl.AutoSize = true;
            Tenlbl.Font = new Font("Times New Roman", 13.8F);
            Tenlbl.Location = new Point(169, 177);
            Tenlbl.Name = "Tenlbl";
            Tenlbl.Size = new Size(54, 26);
            Tenlbl.TabIndex = 26;
            Tenlbl.Text = "Tên:";
            // 
            // XacnhanBtn
            // 
            XacnhanBtn.BackColor = Color.Green;
            XacnhanBtn.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XacnhanBtn.ForeColor = SystemColors.ButtonHighlight;
            XacnhanBtn.Location = new Point(452, 363);
            XacnhanBtn.Name = "XacnhanBtn";
            XacnhanBtn.Size = new Size(249, 69);
            XacnhanBtn.TabIndex = 21;
            XacnhanBtn.Text = "Xác nhận";
            XacnhanBtn.UseVisualStyleBackColor = false;
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
            ThoatBtn.Text = "Thoát";
            ThoatBtn.UseVisualStyleBackColor = false;
            // 
            // MotaTbx
            // 
            MotaTbx.Location = new Point(276, 231);
            MotaTbx.Name = "MotaTbx";
            MotaTbx.Size = new Size(339, 27);
            MotaTbx.TabIndex = 18;
            // 
            // TenTbx
            // 
            TenTbx.Location = new Point(276, 176);
            TenTbx.Name = "TenTbx";
            TenTbx.Size = new Size(339, 27);
            TenTbx.TabIndex = 19;
            // 
            // Suadanhmuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 503);
            Controls.Add(panel1);
            Controls.Add(Motalbl);
            Controls.Add(Tenlbl);
            Controls.Add(XacnhanBtn);
            Controls.Add(ThoatBtn);
            Controls.Add(MotaTbx);
            Controls.Add(TenTbx);
            Name = "Suadanhmuc";
            Text = "Sửa danh mục";
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