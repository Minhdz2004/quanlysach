namespace quanlynhasach
{
    partial class Dangnhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dn = new Button();
            ten = new TextBox();
            makhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // dn
            // 
            dn.Location = new Point(416, 275);
            dn.Margin = new Padding(4, 5, 4, 5);
            dn.Name = "dn";
            dn.Size = new Size(100, 35);
            dn.TabIndex = 0;
            dn.Text = "Đăng nhập";
            dn.UseVisualStyleBackColor = true;
            dn.Click += dn_Click;
            // 
            // ten
            // 
            ten.Location = new Point(312, 156);
            ten.Margin = new Padding(4, 5, 4, 5);
            ten.Name = "ten";
            ten.Size = new Size(204, 27);
            ten.TabIndex = 1;
            // 
            // makhau
            // 
            makhau.Location = new Point(312, 222);
            makhau.Margin = new Padding(4, 5, 4, 5);
            makhau.Name = "makhau";
            makhau.Size = new Size(204, 27);
            makhau.TabIndex = 2;
            makhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 163);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 229);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 64);
            label3.Name = "label3";
            label3.Size = new Size(258, 32);
            label3.TabIndex = 5;
            label3.Text = "Đăng nhập hệ thống";
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 532);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(makhau);
            Controls.Add(ten);
            Controls.Add(dn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dangnhap";
            Text = "Đăng nhập";
            Load += Dangnhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button dn;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox makhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Label label3;
    }
}
