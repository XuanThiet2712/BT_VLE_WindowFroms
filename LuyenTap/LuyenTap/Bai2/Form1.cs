using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Bai2
{
    public partial class Form1: Form
    {
        private Image anhNen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic2.Image = Properties.Resources.NH;
            string path = Path.Combine(Application.StartupPath, "Anh", "1g.jpg");
            if (File.Exists(path))
            {
                pic3.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("Ko tim thay file");
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            pictureBox4.LoadCompleted += (s, ev) =>
            {
                if (ev.Error != null)
                {
                    MessageBox.Show($"Error: {ev.Error.Message}");
                }
            };

            pictureBox4.LoadAsync("https://picsum.photos/200");

            cboLayout.DataSource = Enum.GetValues(typeof(ImageLayout));

            anhNen = Properties.Resources.NH;
            this.BackgroundImage = anhNen;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chojn anh ";
            dlg.Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tất cả file|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pic5.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void btnDanAnh_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
                pictureBox6.Image = Clipboard.GetImage();
            else
                MessageBox.Show("Clipboard chưa có ảnh!\nHãy bấm Print Screen hoặc copy một ảnh trước.");
        }

        private void cboLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = (ImageLayout)cboLayout.SelectedItem;
        }
    }
}
