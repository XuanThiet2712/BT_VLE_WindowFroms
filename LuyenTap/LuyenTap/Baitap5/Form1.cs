using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            btnDaiDien.Size = new Size(btnDaiDien.Width + 10 , btnDaiDien.Height + 10);
            lblInfo.Text = $"Size: {btnDaiDien.Width} x {btnDaiDien.Height}";
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            int w = btnDaiDien.Width - 10; 
            int h = btnDaiDien.Height - 10;

            if ( w > 30 && h > 20 )
            {
                btnDaiDien.Size = new Size (w, h);
            }
            else
            {
                 if ( h > 20 ) 
                    btnDaiDien.Height = h;
else if ( w > 30 ) btnDaiDien.Width = w;
            }
            lblInfo.Text = $"Size: {btnDaiDien.Width} x {btnDaiDien.Height}";

        }
    }
}
