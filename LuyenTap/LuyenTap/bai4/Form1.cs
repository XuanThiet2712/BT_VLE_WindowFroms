using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1: Form
    {
        private frmMau mau;
        private int soNut = 0; 
        private bool dangDongBo = false;
        private static readonly Dictionary<string, Cursor> dsCursor = new Dictionary<string, Cursor>
        {
            { "Default",    Cursors.Default },
            { "Hand",       Cursors.Hand },
            { "Cross",      Cursors.Cross },
            { "WaitCursor", Cursors.WaitCursor },
            { "No",         Cursors.No }
        };
        public Form1()
        {
            InitializeComponent();
            CapNhatTrangThai();
            cboBorder.DataSource = Enum.GetValues(typeof(FormBorderStyle));
            cboCursor.DataSource = new List<string>(dsCursor.Keys);
            
            

        }
        private void CapNhatTrangThai()
        {
            btnMoMau.Text = (mau == null) ? "Mở form mẫu" : "Đóng form mẫu";
            pnlDieuKhien.Enabled = (mau != null);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMoDau_Click(object sender, EventArgs e)
        {
            if (mau == null)
            {
                mau = new frmMau();
                
                mau.FormClosed += Mau_FormClosed;     // biết khi người dùng tự đóng form mẫu

                // Đặt form mẫu cạnh bên phải bảng điều khiển để cả hai cùng thấy
                mau.StartPosition = FormStartPosition.Manual;
                mau.Location = new Point(this.Right + 10, this.Top);

                mau.Show();                            // KHÔNG dùng ShowDialog (giải thích bên dưới)
            }
            else
            {
                mau.Close();
            }

            CapNhatTrangThai();
        }

        private void Mau_FormClosed(object sender, FormClosedEventArgs e)
        {
            mau = null;
            soNut = 0;
            CapNhatTrangThai();
        }

        private void cboBoder_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (mau == null || dangDongBo) return;

            mau.FormBorderStyle = (FormBorderStyle)cboBorder.SelectedItem;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblOpacity.Text = trkOpacity.Value + "%";

            if (mau == null || dangDongBo) return;
            mau.Opacity = trkOpacity.Value / 100.0;
        }

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;
            mau.TopMost = chkTopMost.Checked;
        }

        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;
            if (radNormal.Checked) mau.WindowState = FormWindowState.Normal;
        }

        private void radMin_CheckedChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;
            if (radMin.Checked) mau.WindowState = FormWindowState.Minimized;
        }

        private void radMax_CheckedChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;
            if (radMax.Checked) mau.WindowState = FormWindowState.Maximized;
        }

        private void cboCursor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;

            string ten = cboCursor.SelectedItem.ToString();
            mau.Cursor = dsCursor[ten];
            
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            if (mau == null) return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn file icon";
                dlg.Filter = "Icon|*.ico";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        mau.Icon = new Icon(dlg.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File icon không hợp lệ:\n" + ex.Message);
                    }
                }
            }
        }

        private void chkTaskbar_CheckedChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;
            mau.ShowInTaskbar = chkTaskbar.Checked;
        }

        private void chkControlBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;
            mau.ControlBox = chkControlBox.Checked;
        }

        private void chkMaximizeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;
            mau.MaximizeBox = chkMaximizeBox.Checked;
        }

        private void btnThemNut_Click(object sender, EventArgs e)
        {
            if (mau == null) return;

            soNut++;

            Button b = new Button();
            b.Text = "Nút " + soNut;
            b.Tag = "dong";                                       // đánh dấu nút này do code tạo
            b.Size = new Size(90, 28);
            b.Location = new Point(10, 40 + (soNut - 1) * 34);   // mỗi nút thấp hơn nút trước 34 pixel
            b.Click += (s, ev) => MessageBox.Show("Bạn vừa bấm " + ((Button)s).Text);

            mau.Controls.Add(b);
        }

        private void btnXoaNut_Click(object sender, EventArgs e)
        {
            if (mau == null) return;

            for (int i = mau.Controls.Count - 1; i >= 0; i--)    // duyệt NGƯỢC
            {
                Control c = mau.Controls[i];

                if (c.Tag != null && c.Tag.ToString() == "dong")  // chỉ xóa nút do code tạo, giữ Label
                {
                    mau.Controls.Remove(c);
                    c.Dispose();
                }
            }

            soNut = 0;
        }

        private void chkAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            if (mau == null || dangDongBo) return;

            mau.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mau.AutoSize = chkAutoSize.Checked;
        }
    }


}
