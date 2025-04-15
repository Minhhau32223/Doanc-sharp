namespace Doanc_sharp
{
    partial class DanhMuc
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Tendanhmuc = new DataGridViewTextBoxColumn();
            Mota = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            EditBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Tendanhmuc, Mota });
            dataGridView1.Location = new Point(35, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1014, 747);
            dataGridView1.TabIndex = 5;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Tendanhmuc
            // 
            Tendanhmuc.HeaderText = "Tên danh mục";
            Tendanhmuc.MinimumWidth = 6;
            Tendanhmuc.Name = "Tendanhmuc";
            Tendanhmuc.Width = 350;
            // 
            // Mota
            // 
            Mota.HeaderText = "Mô tả";
            Mota.MinimumWidth = 6;
            Mota.Name = "Mota";
            Mota.Width = 460;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.BackgroundImage = Properties.Resources.plus_icon;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(999, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(306, 46);
            label1.TabIndex = 3;
            label1.Text = "Danh mục thiết bị";
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Segoe UI", 22F);
            EditBtn.Location = new Point(849, 835);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(200, 60);
            EditBtn.TabIndex = 6;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // DanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(EditBtn);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "DanhMuc";
            Size = new Size(1080, 900);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tendanhmuc;
        private DataGridViewTextBoxColumn Mota;
        private Button EditBtn;
    }
}