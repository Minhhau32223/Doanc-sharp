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
            label1 = new Label();
            button1 = new Button();
            enterMTV = new TextBox();
            txtMaVach = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            textInforCheckin = new TextBox();
            textInforEmail = new TextBox();
            textInforSdt = new TextBox();
            textInforNgaydk = new TextBox();
            textInforDiachi = new TextBox();
            textInforTen = new TextBox();
            textInforMa = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(503, 31);
            label1.TabIndex = 3;
            label1.Text = "KIỂM TRA TRƯỚC KHI VÀO THƯ QUÁN";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Times New Roman", 19.8000011F);
            button1.Location = new Point(109, 62);
            button1.Margin = new Padding(3, 2, 3, 20);
            button1.Name = "button1";
            button1.Size = new Size(175, 39);
            button1.TabIndex = 0;
            button1.Text = "KIỂM TRA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // enterMTV
            // 
            enterMTV.Anchor = AnchorStyles.None;
            enterMTV.Font = new Font("Times New Roman", 19.8000011F);
            enterMTV.ForeColor = SystemColors.ScrollBar;
            enterMTV.Location = new Point(3, 2);
            enterMTV.Margin = new Padding(3, 2, 3, 20);
            enterMTV.Name = "enterMTV";
            enterMTV.Size = new Size(388, 38);
            enterMTV.TabIndex = 1;
            enterMTV.Text = "Nhập mã thành viên...";
            enterMTV.Enter += onInput;
            enterMTV.KeyPress += checkEnter;
            // 
            // txtMaVach
            // 
            txtMaVach.Anchor = AnchorStyles.None;
            txtMaVach.Font = new Font("Times New Roman", 12.00001F);
            txtMaVach.Location = new Point(139, 123);
            txtMaVach.Margin = new Padding(3, 2, 3, 2);
            txtMaVach.Name = "txtMaVach";
            txtMaVach.Size = new Size(116, 29);
            txtMaVach.TabIndex = 2;
            txtMaVach.Text = "quét mã vạch";
            txtMaVach.UseVisualStyleBackColor = true;
            txtMaVach.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(enterMTV);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(txtMaVach);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(31, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(393, 159);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(textInforCheckin);
            panel1.Controls.Add(textInforEmail);
            panel1.Controls.Add(textInforSdt);
            panel1.Controls.Add(textInforNgaydk);
            panel1.Controls.Add(textInforDiachi);
            panel1.Controls.Add(textInforTen);
            panel1.Controls.Add(textInforMa);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(515, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 526);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // textInforCheckin
            // 
            textInforCheckin.Location = new Point(194, 342);
            textInforCheckin.Name = "textInforCheckin";
            textInforCheckin.ReadOnly = true;
            textInforCheckin.Size = new Size(209, 23);
            textInforCheckin.TabIndex = 10;
            textInforCheckin.TextChanged += textBox7_TextChanged;
            // 
            // textInforEmail
            // 
            textInforEmail.Location = new Point(194, 300);
            textInforEmail.Name = "textInforEmail";
            textInforEmail.ReadOnly = true;
            textInforEmail.Size = new Size(209, 23);
            textInforEmail.TabIndex = 10;
            // 
            // textInforSdt
            // 
            textInforSdt.Location = new Point(194, 256);
            textInforSdt.Name = "textInforSdt";
            textInforSdt.ReadOnly = true;
            textInforSdt.Size = new Size(209, 23);
            textInforSdt.TabIndex = 10;
            // 
            // textInforNgaydk
            // 
            textInforNgaydk.Location = new Point(194, 208);
            textInforNgaydk.Name = "textInforNgaydk";
            textInforNgaydk.ReadOnly = true;
            textInforNgaydk.Size = new Size(209, 23);
            textInforNgaydk.TabIndex = 10;
            // 
            // textInforDiachi
            // 
            textInforDiachi.Location = new Point(194, 165);
            textInforDiachi.Name = "textInforDiachi";
            textInforDiachi.ReadOnly = true;
            textInforDiachi.Size = new Size(209, 23);
            textInforDiachi.TabIndex = 10;
            // 
            // textInforTen
            // 
            textInforTen.Location = new Point(194, 115);
            textInforTen.Name = "textInforTen";
            textInforTen.ReadOnly = true;
            textInforTen.Size = new Size(209, 23);
            textInforTen.TabIndex = 9;
            // 
            // textInforMa
            // 
            textInforMa.Location = new Point(194, 74);
            textInforMa.Name = "textInforMa";
            textInforMa.ReadOnly = true;
            textInforMa.Size = new Size(209, 23);
            textInforMa.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 342);
            label9.Name = "label9";
            label9.Size = new Size(157, 23);
            label9.TabIndex = 7;
            label9.Text = "Vào thư quán lúc:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 300);
            label8.Name = "label8";
            label8.Size = new Size(63, 23);
            label8.TabIndex = 7;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 256);
            label7.Name = "label7";
            label7.Size = new Size(125, 23);
            label7.TabIndex = 7;
            label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 208);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 7;
            label6.Text = "Ngày đăng ký:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 162);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 7;
            label5.Text = "Địa chỉ:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 115);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 7;
            label4.Text = "Tên thành viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 74);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 7;
            label3.Text = "Mã thành viên:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F);
            label2.Location = new Point(88, 11);
            label2.Name = "label2";
            label2.Size = new Size(241, 31);
            label2.TabIndex = 6;
            label2.Text = "Thông tin thành viên";
            // 
            // KiemTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KiemTra";
            Size = new Size(945, 675);
            Load += KiemTra_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox enterMTV;
        private Button txtMaVach;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textInforMa;
        private TextBox textInforCheckin;
        private TextBox textInforEmail;
        private TextBox textInforSdt;
        private TextBox textInforNgaydk;
        private TextBox textInforDiachi;
        private TextBox textInforTen;
    }
}