using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in pnlLuoi.Controls)
            {
                if (c is Button)
                    c.Click += NutCanLe_Click;
            }
        }

        private void lblMau_Click(object sender, EventArgs e)
        {

        }

        private void txtMau_TextChanged(object sender, EventArgs e)
        {
            txtMau.Text = txtMau.Text.Trim();
        }

        private void NutNen_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;        // nút nào vừa bị bấm
            lblMau.BackColor = nut.BackColor;   // lấy màu của chính nó
        }
        private void NutCanLe_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;
            string ten = nut.Tag.ToString();   // ví dụ "TopLeft"
            lblMau.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), ten);
        }
        private void NutChu_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;
            lblMau.ForeColor = nut.BackColor;
        }

        private void DoiCoChu(float delta)
        {
            float size = new float() ;
            if (delta > 0)
            {
                size = Math.Min(40, lblMau.Font.Size + delta);
            }
            else if (delta < 0)
            {
                size = Math.Max(8, lblMau.Font.Size + delta);
            }
                lblMau.Font = new Font(lblMau.Font.FontFamily, size , lblMau.Font.Style );
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            DoiCoChu(2);
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            DoiCoChu(-2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            lblMau.Font = new Font(lblMau.Font, FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            lblMau.Font = new Font(lblMau.Font , FontStyle.Italic);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
