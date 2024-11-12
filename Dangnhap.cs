using System;
using System.Windows.Forms;

namespace quanlynhasach
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string name = ten.Text;
            string password = makhau.Text;

            if (IsValidPassword(password, name))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private bool IsValidPassword(string password, string name)
        {
            if (password == "1234" && name == "admin")
                return true;
            return false;
        }
    }
}
