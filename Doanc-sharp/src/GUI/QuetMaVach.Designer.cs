﻿namespace Doanc_sharp.src.GUI
{
    partial class QuetMaVach
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
            pictureBox1 = new PictureBox();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(173, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 258);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(275, 293);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(249, 23);
            txtResult.TabIndex = 1;
            // 
            // QuetMaVach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(pictureBox1);
            Name = "QuetMaVach";
            Text = "QuetMaVach";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtResult;
    }
}