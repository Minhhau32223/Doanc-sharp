namespace Doanc_sharp.src.GUI
{
    partial class KiemTra
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
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            txtMaVach = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 19.8000011F);
            button1.Location = new Point(158, 81);
            button1.Name = "button1";
            button1.Size = new Size(200, 52);
            button1.TabIndex = 0;
            button1.Text = "KIỂM TRA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 19.8000011F);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(64, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 45);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nhập mã thành viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaVach);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(138, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 223);
            panel1.TabIndex = 2;
            // 
            // txtMaVach
            // 
            txtMaVach.Font = new Font("Times New Roman", 12.00001F);
            txtMaVach.Location = new Point(193, 165);
            txtMaVach.Name = "txtMaVach";
            txtMaVach.Size = new Size(133, 39);
            txtMaVach.TabIndex = 2;
            txtMaVach.Text = "quét mã vạch";
            txtMaVach.UseVisualStyleBackColor = true;
            txtMaVach.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F);
            label1.Location = new Point(78, 45);
            label1.Name = "label1";
            label1.Size = new Size(644, 39);
            label1.TabIndex = 3;
            label1.Text = "KIỂM TRA TRƯỚC KHI VÀO THƯ QUÁN";
            // 
            // KiemTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "KiemTra";
            Size = new Size(800, 503);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Button txtMaVach;
        private Label label1;
    }
}