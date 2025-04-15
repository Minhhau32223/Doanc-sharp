namespace Doanc_sharp
{
    partial class ThemThietBi
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 95);
            panel1.TabIndex = 0;
       
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(273, 51);
            label1.TabIndex = 0;
            label1.Text = "Thêm thiết bị";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(402, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(402, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(402, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 27);
            textBox3.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(402, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 28);
            comboBox1.TabIndex = 2;
            
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(103, 360);
            button1.Name = "button1";
            button1.Size = new Size(249, 69);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(451, 360);
            button2.Name = "button2";
            button2.Size = new Size(249, 69);
            button2.TabIndex = 3;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(197, 129);
            label2.Name = "label2";
            label2.Size = new Size(42, 26);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(197, 182);
            label3.Name = "label3";
            label3.Size = new Size(124, 26);
            label3.TabIndex = 4;
            label3.Text = "Tên thiết bị:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(197, 231);
            label4.Name = "label4";
            label4.Size = new Size(50, 26);
            label4.TabIndex = 4;
            label4.Text = "Giá:";
           
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(197, 283);
            label5.Name = "label5";
            label5.Size = new Size(112, 26);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái:";
            // 
            // ThemThietBi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 503);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "ThemThietBi";
            Text = "Thêm thiết bị";
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}