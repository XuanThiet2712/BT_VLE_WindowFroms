using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuocTinhControls
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMau_TextChanged(object sender, EventArgs e)
        {
            lblMau.Text = txtMau.Text;
        }


        private void btnNenXanh_Click_1(object sender, EventArgs e)
        {
            lblMau.BackColor = Color.Blue;
        }

        private void btnNenVang_Click(object sender, EventArgs e)
        {
            lblMau.BackColor = Color.Yellow;
        }

        private void btnChuDo_Click(object sender, EventArgs e)
        {
            lblMau.ForeColor = Color.Red;
        }

        private void btnChuDen_Click(object sender, EventArgs e)
        {
            lblMau.ForeColor = Color.Black;
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            lblMau.Font = new Font(lblMau.Font.FontFamily, lblMau.Font.Size + 2 , lblMau.Font.Style);
            
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            lblMau.Font = new Font(lblMau.Font.FontFamily, lblMau.Font.Size - 2, lblMau.Font.Style);
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            lblMau.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void chkDam_CheckedChanged(object sender, EventArgs e)
        {
            lblMau.Font = new Font(lblMau.Font , FontStyle.Bold);
        }

        private void btnGiua_Click(object sender, EventArgs e)
        {
            lblMau.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            lblMau.TextAlign = ContentAlignment.MiddleRight;
        }

        private void chkHien_CheckedChanged(object sender, EventArgs e)
        {
            lblMau.Visible = chkHien.Checked;
        }

        private void chkChoSua_CheckedChanged(object sender, EventArgs e)
        {
            txtMau.Visible = chkChoSua.Checked;
        }
    }
}
