namespace Doanc_sharp
{
    partial class Chitietbaotri
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
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(506, 435);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 28);
            comboBox1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 95);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(299, 51);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết bảo trì";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(259, 435);
            label5.Name = "label5";
            label5.Size = new Size(112, 26);
            label5.TabIndex = 23;
            label5.Text = "Trạng thái:";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(259, 498);
            label4.Name = "label4";
            label4.Size = new Size(114, 26);
            label4.TabIndex = 24;
            label4.Text = "Nhân viên:";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(259, 202);
            label3.Name = "label3";
            label3.Size = new Size(124, 26);
            label3.TabIndex = 25;
            label3.Text = "Tên thiết bị:";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(259, 125);
            label2.Name = "label2";
            label2.Size = new Size(42, 26);
            label2.TabIndex = 26;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(561, 640);
            button2.Name = "button2";
            button2.Size = new Size(249, 69);
            button2.TabIndex = 21;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(193, 640);
            button1.Name = "button1";
            button1.Size = new Size(249, 69);
            button1.TabIndex = 22;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(506, 499);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(506, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(506, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 27);
            textBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(261, 268);
            label6.Name = "label6";
            label6.Size = new Size(71, 26);
            label6.TabIndex = 27;
            label6.Text = "Mô tả:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(506, 267);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(339, 27);
            textBox4.TabIndex = 18;
            
            // 
            // Chitietbaotri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1006, 733);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Chitietbaotri";
            Text = "Form2";
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
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox4;
    }
}