using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            chkKhach.CheckedChanged += AnHien;
        }

        private void AnHien(object sender, EventArgs e)
        {
            if (chkKhach.Checked)
            {
                lblMatKhau.Hide();
                txtMatKhau.Hide();
            }
            else
            {
                lblMatKhau.Show();
                txtMatKhau.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            picAnh.Hide();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            picAnh.Show();
        }
    }
}
