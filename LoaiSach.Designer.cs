namespace quanlynhasach
{
    partial class LoaiSach
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
            dataloaisach = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataloaisach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 23);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "Bảng loại sách";
            // 
            // dataloaisach
            // 
            dataloaisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataloaisach.Location = new Point(149, 89);
            dataloaisach.Name = "dataloaisach";
            dataloaisach.RowHeadersWidth = 51;
            dataloaisach.Size = new Size(528, 236);
            dataloaisach.TabIndex = 1;
            dataloaisach.CellContentClick += dataloaisach_CellContentClick;
            // 
            // LoaiSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 490);
            Controls.Add(dataloaisach);
            Controls.Add(label1);
            Name = "LoaiSach";
            Text = "LoaiSach";
            Load += LoaiSach_Load;
            ((System.ComponentModel.ISupportInitialize)dataloaisach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataloaisach;
    }
}