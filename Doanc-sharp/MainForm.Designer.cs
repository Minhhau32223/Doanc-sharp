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
            Rightpanel = new Panel();
            leftmenu1 = new Leftmenu();
            Leftpanel.SuspendLayout();
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
            // Rightpanel
            // 
            Rightpanel.BackColor = Color.FromArgb(184, 145, 99);
            Rightpanel.Location = new Point(303, 2);
            Rightpanel.Name = "Rightpanel";
            Rightpanel.Size = new Size(1124, 1011);
            Rightpanel.TabIndex = 1;
            // 
            // leftmenu1
            // 
            leftmenu1.BackColor = Color.Beige;
            leftmenu1.Location = new Point(3, 0);
            leftmenu1.Name = "leftmenu1";
            leftmenu1.Size = new Size(294, 1011);
            leftmenu1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 1011);
            Controls.Add(Rightpanel);
            Controls.Add(Leftpanel);
            Font = new Font("Segoe UI", 9F);
            Name = "MainForm";
            Text = "Thư quán";
            Load += Form1_Load;
            Leftpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Panel Leftpanel;
        private Leftmenu leftmenu1;
        private Panel Rightpanel;
    }
}
