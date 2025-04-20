namespace Doanc_sharp
{
    partial class Themphieumuon
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
            BtnXacnhan = new Button();
            BtnThoat = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            CbbTrangthai = new ComboBox();
            textBoxMaphieumuon = new TextBox();
            Mathanhvien = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listView1 = new ListView();
            button1 = new Button();
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
            label1.Size = new Size(288, 40);
            label1.TabIndex = 0;
            label1.Text = "Thêm phiếu mượn";
            // 
            // BtnXacnhan
            // 
            BtnXacnhan.BackColor = Color.Green;
            BtnXacnhan.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnXacnhan.ForeColor = SystemColors.ButtonHighlight;
            BtnXacnhan.Location = new Point(410, 423);
            BtnXacnhan.Margin = new Padding(3, 2, 3, 2);
            BtnXacnhan.Name = "BtnXacnhan";
            BtnXacnhan.Size = new Size(218, 52);
            BtnXacnhan.TabIndex = 21;
            BtnXacnhan.Text = "Xác nhận";
            BtnXacnhan.UseVisualStyleBackColor = false;
            // 
            // BtnThoat
            // 
            BtnThoat.BackColor = Color.Red;
            BtnThoat.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnThoat.ForeColor = SystemColors.ButtonHighlight;
            BtnThoat.Location = new Point(77, 423);
            BtnThoat.Margin = new Padding(3, 2, 3, 2);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(218, 52);
            BtnThoat.TabIndex = 22;
            BtnThoat.Text = "Thoát";
            BtnThoat.UseVisualStyleBackColor = false;
            BtnThoat.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 86);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 23;
            label2.Text = "Mã phiếu mượn";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 133);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 24;
            label3.Text = "Mã thành viên";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 218);
            label4.Name = "label4";
            label4.Size = new Size(149, 23);
            label4.TabIndex = 25;
            label4.Text = "Ngày trả dự kiến";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 176);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 25;
            label5.Text = "Ngày mượn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(77, 255);
            label7.Name = "label7";
            label7.Size = new Size(160, 23);
            label7.TabIndex = 27;
            label7.Text = "Danh sách thiết bị";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(77, 367);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
            label8.TabIndex = 28;
            label8.Text = "Trạng thái";
            label8.Click += label8_Click;
            // 
            // CbbTrangthai
            // 
            CbbTrangthai.FormattingEnabled = true;
            CbbTrangthai.Items.AddRange(new object[] { "Đang mượn" });
            CbbTrangthai.Location = new Point(260, 370);
            CbbTrangthai.Name = "CbbTrangthai";
            CbbTrangthai.Size = new Size(277, 23);
            CbbTrangthai.TabIndex = 29;
            CbbTrangthai.SelectedIndexChanged += CbbTrangthai_SelectedIndexChanged;
            // 
            // textBoxMaphieumuon
            // 
            textBoxMaphieumuon.Location = new Point(260, 89);
            textBoxMaphieumuon.Name = "textBoxMaphieumuon";
            textBoxMaphieumuon.Size = new Size(277, 23);
            textBoxMaphieumuon.TabIndex = 30;
            // 
            // Mathanhvien
            // 
            Mathanhvien.Location = new Point(260, 136);
            Mathanhvien.Name = "Mathanhvien";
            Mathanhvien.Size = new Size(277, 23);
            Mathanhvien.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 23);
            textBox2.TabIndex = 33;
            textBox2.Text = "null";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(260, 255);
            listView1.Name = "listView1";
            listView1.Size = new Size(277, 95);
            listView1.TabIndex = 34;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(543, 255);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 35;
            button1.Text = "Chọn thiết bị";
            button1.UseVisualStyleBackColor = true;
            // 
            // Themphieumuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 495);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Mathanhvien);
            Controls.Add(textBoxMaphieumuon);
            Controls.Add(CbbTrangthai);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(BtnXacnhan);
            Controls.Add(BtnThoat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Themphieumuon";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button BtnXacnhan;
        private Button BtnThoat;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private ComboBox CbbTrangthai;
        private TextBox textBoxMaphieumuon;
        private TextBox Mathanhvien;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListView listView1;
        private Button button1;
    }
}