namespace quanlynhasach
{
    partial class Sach
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
            datasach = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label2 = new Label();
            textmas = new TextBox();
            label3 = new Label();
            texttens = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textgias = new TextBox();
            textsol = new TextBox();
            textmota = new TextBox();
            textmals = new TextBox();
            btnTimKiem = new Button();
            label8 = new Label();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)datasach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(528, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 0;
            label1.Text = "Bảng sách";
           // label1.Click += label1_Click;
            // 
            // datasach
            // 
            datasach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasach.Location = new Point(191, 101);
            datasach.Name = "datasach";
            datasach.RowHeadersWidth = 51;
            datasach.Size = new Size(825, 214);
            datasach.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(191, 476);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(572, 476);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(933, 476);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 347);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã sách";
            // 
            // textmas
            // 
            textmas.Location = new Point(280, 347);
            textmas.Name = "textmas";
            textmas.Size = new Size(139, 27);
            textmas.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 394);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên sách";
            // 
            // texttens
            // 
            texttens.Location = new Point(283, 394);
            texttens.Name = "texttens";
            texttens.Size = new Size(136, 27);
            texttens.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 350);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 401);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(756, 354);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 11;
            label6.Text = "Mô tả";
            //label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(756, 401);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 12;
            label7.Text = "Mã loại sách";
            // 
            // textgias
            // 
            textgias.Location = new Point(553, 347);
            textgias.Name = "textgias";
            textgias.Size = new Size(173, 27);
            textgias.TabIndex = 13;
            // 
            // textsol
            // 
            textsol.Location = new Point(553, 394);
            textsol.Name = "textsol";
            textsol.Size = new Size(172, 27);
            textsol.TabIndex = 14;
            // 
            // textmota
            // 
            textmota.Location = new Point(859, 347);
            textmota.Name = "textmota";
            textmota.Size = new Size(157, 27);
            textmota.TabIndex = 15;
            // 
            // textmals
            // 
            textmals.Location = new Point(859, 394);
            textmals.Name = "textmals";
            textmals.Size = new Size(157, 27);
            textmals.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(849, 56);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 60);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 18;
            label8.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(337, 56);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(494, 27);
            txtTimKiem.TabIndex = 19;
            // 
            // Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 537);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(btnTimKiem);
            Controls.Add(textmals);
            Controls.Add(textmota);
            Controls.Add(textsol);
            Controls.Add(textgias);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(texttens);
            Controls.Add(label3);
            Controls.Add(textmas);
            Controls.Add(label2);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(datasach);
            Controls.Add(label1);
            Name = "Sach";
            Text = "Sach";
            Load += Sach_Load;
            ((System.ComponentModel.ISupportInitialize)datasach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView datasach;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label2;
        private TextBox textmas;
        private Label label3;
        private TextBox texttens;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textgias;
        private TextBox textsol;
        private TextBox textmota;
        private TextBox textmals;
        private Button btnTimKiem;
        private Label label8;
        private TextBox txtTimKiem;
    }
}