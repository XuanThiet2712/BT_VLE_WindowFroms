using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBox.TextChanged += CapNhatNut;
            chkBox.CheckedChanged += CapNhatNut;
          
        }
        
        private void CapNhatNut(object sender, EventArgs e)
        {
            btnDongY.Enabled = chkBox.Checked && !string.IsNullOrWhiteSpace(txtBox.Text);
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkBox.Checked && !(txtBox.Text == string.Empty))
            //{
            //    btnDongY.Enabled = true;
            //}
            //else
            //{
            //    btnDongY.Enabled = false;
            //}
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            txtBox.Enabled = !txtBox.Enabled;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            //if (chkBox.Checked && !(txtBox.Text == string.Empty))
            //{
            //    btnDongY.Enabled = true;
            //}
            //else
            //{
            //    btnDongY.Enabled = false;
            //}
        }
    }
}
