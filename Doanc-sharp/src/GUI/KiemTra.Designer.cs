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
            flowLayoutPanel1.SuspendLayout();
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
            flowLayoutPanel1.Location = new Point(290, 238);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(393, 159);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // KiemTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KiemTra";
            Size = new Size(945, 675);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox enterMTV;
        private Button txtMaVach;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}