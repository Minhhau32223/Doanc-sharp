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
            txtDeviceID = new TextBox();
            txtDeviceName = new TextBox();
            txtRentPrice = new TextBox();
            btnConfirm = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStatus = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(216, 40);
            label1.TabIndex = 0;
            label1.Text = "Thêm thiết bị";
            label1.Click += label1_Click;
            // 
            // txtDeviceID
            // 
            txtDeviceID.Location = new Point(352, 92);
            txtDeviceID.Margin = new Padding(3, 2, 3, 2);
            txtDeviceID.Name = "txtDeviceID";
            txtDeviceID.Size = new Size(297, 23);
            txtDeviceID.TabIndex = 1;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new Point(352, 131);
            txtDeviceName.Margin = new Padding(3, 2, 3, 2);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(297, 23);
            txtDeviceName.TabIndex = 1;
            // 
            // txtRentPrice
            // 
            txtRentPrice.Location = new Point(352, 168);
            txtRentPrice.Margin = new Padding(3, 2, 3, 2);
            txtRentPrice.Name = "txtRentPrice";
            txtRentPrice.Size = new Size(297, 23);
            txtRentPrice.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Green;
            btnConfirm.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Location = new Point(395, 270);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(218, 52);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(172, 97);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(172, 136);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 4;
            label3.Text = "Tên thiết bị:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(172, 173);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 4;
            label4.Text = "Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(172, 212);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(352, 210);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(297, 23);
            txtStatus.TabIndex = 1;
            // 
            // ThemThietBi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 377);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(txtStatus);
            Controls.Add(txtRentPrice);
            Controls.Add(txtDeviceName);
            Controls.Add(txtDeviceID);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThemThietBi";
            Text = "Thêm thiết bị";
            Load += ThemThietBi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtDeviceID;
        private TextBox txtDeviceName;
        private TextBox txtRentPrice;

        public Button btnClose { get; private set; }

        private ComboBox comboBox1;
        private Button button1;
        private Button btnConfirm;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStatus;
    }
}