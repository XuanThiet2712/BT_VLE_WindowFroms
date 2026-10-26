using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txtTest.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Đã bấm";
            Text = txtTest.Text;
        }
    }
}
