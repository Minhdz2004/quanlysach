﻿using System;
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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }
        ketnoi kn=new ketnoi();
 
        private void Sach_Load(object sender, EventArgs e)
        {

        }
        public void getData()
        {
            string query = "select * from Sach";
            DataSet ds = kn.LayDuLieu(query);
            datasach.DataSource = ds.Tables[0];
        }
    }
}
