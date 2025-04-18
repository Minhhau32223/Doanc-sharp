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
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 19.8000011F);
            button1.Location = new Point(138, 61);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(175, 39);
            button1.TabIndex = 0;
            button1.Text = "KIỂM TRA";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 19.8000011F);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(56, 2);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 38);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nhập mã thành viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(121, 97);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 167);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12.00001F);
            button2.Location = new Point(169, 124);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 2;
            button2.Text = "quét mã vạch";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // KiemTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 377);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KiemTra";
            Text = "KiemTra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Button button2;
    }
}