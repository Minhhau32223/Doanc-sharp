namespace Doanc_sharp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            Leftpanel = new Panel();
            leftmenu1 = new Leftmenu();
            Rightpanel = new Panel();
            headerpanel = new Panel();
            youraccount = new Label();
            Leftpanel.SuspendLayout();
            headerpanel.SuspendLayout();
            SuspendLayout();
            // 
            // Leftpanel
            // 
            Leftpanel.Controls.Add(leftmenu1);
            Leftpanel.Location = new Point(0, 2);
            Leftpanel.Name = "Leftpanel";
            Leftpanel.Size = new Size(300, 1024);
            Leftpanel.TabIndex = 1;
            // 
            // leftmenu1
            // 
            leftmenu1.BackColor = Color.Beige;
            leftmenu1.Location = new Point(0, 0);
            leftmenu1.Name = "leftmenu1";
            leftmenu1.Size = new Size(300, 1011);
            leftmenu1.TabIndex = 0;
            leftmenu1.Load += leftmenu1_Load_1;
            // 
            // Rightpanel
            // 
            Rightpanel.BackColor = Color.FromArgb(184, 145, 99);
            Rightpanel.Location = new Point(303, 117);
            Rightpanel.Name = "Rightpanel";
            Rightpanel.Size = new Size(1021, 896);
            Rightpanel.TabIndex = 1;
            Rightpanel.Paint += Rightpanel_Paint;
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.FromArgb(255, 234, 180);
            headerpanel.Controls.Add(youraccount);
            headerpanel.Location = new Point(303, -5);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1021, 122);
            headerpanel.TabIndex = 2;
            headerpanel.Paint += headerpanel_Paint;
            // 
            // youraccount
            // 
            youraccount.AutoSize = true;
            youraccount.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            youraccount.Location = new Point(485, 38);
            youraccount.Name = "youraccount";
            youraccount.Size = new Size(345, 36);
            youraccount.TabIndex = 0;
            youraccount.Text = "Tài khoản đang đăng nhập";
            youraccount.Click += youraccount_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 941);
            Controls.Add(headerpanel);
            Controls.Add(Rightpanel);
            Controls.Add(Leftpanel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thư quán";
            Load += Form1_Load;
            Leftpanel.ResumeLayout(false);
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Panel Leftpanel;
        private Panel Rightpanel;
        private Leftmenu leftmenu1;
        private Panel headerpanel;
        private Label youraccount;
    }
}
