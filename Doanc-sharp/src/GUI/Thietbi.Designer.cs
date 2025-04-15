namespace Doanc_sharp
{
    partial class Thietbi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Ten_ThietBi = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(143, 46);
            label1.TabIndex = 0;
            label1.Text = "Thiết bị";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.BackgroundImage = Properties.Resources.plus_icon;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(1009, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Ten_ThietBi, Gia, Trangthai });
            dataGridView1.Location = new Point(35, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1014, 798);
            dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Ten_ThietBi
            // 
            Ten_ThietBi.HeaderText = "Tên thiết bị";
            Ten_ThietBi.MinimumWidth = 6;
            Ten_ThietBi.Name = "Ten_ThietBi";
            Ten_ThietBi.Width = 350;
            // 
            // Gia
            // 
            Gia.HeaderText = "GIá";
            Gia.MinimumWidth = 6;
            Gia.Name = "Gia";
            Gia.Width = 250;
            // 
            // Trangthai
            // 
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 250;
            // 
            // Thietbi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Thietbi";
            Size = new Size(1080, 900);
            Load += Thietbi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten_ThietBi;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
