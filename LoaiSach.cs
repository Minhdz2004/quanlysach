using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhasach
{
    public partial class LoaiSach : Form
    {
        public LoaiSach()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void LoaiSach_Load(object sender, EventArgs e)
        {
            getData();
        }
        


        private void dataloaisach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void getData()
        {
            string query = "select * from Loaisach";
            DataSet ds = kn.LayDuLieu(query);
            dataloaisach.DataSource = ds.Tables[0];
        }
    }
}
