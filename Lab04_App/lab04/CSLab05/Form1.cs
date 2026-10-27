using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLab05
{
    public partial class Form1: Form
    {
        private string[] folderFile = null;
        private int selected = 0;

        private int begin = 0;
        private int end = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextImage()
        {
            if (selected == folderFile.Length - 1)
            {
                selected = 0;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected + 1;
                showImage(folderFile[selected]);
            }
        }

        private void prevImage()
        {
            if (selected == 0)
            {
                selected = folderFile.Length - 1;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected - 1;
                showImage(folderFile[selected]);
            }
        }
        private void showImage(string path)
        {
            Image imgtemp = Image.FromFile(path);         
            pictureBox1.Image = imgtemp;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string[] part1 = null , part2 = null , part3 = null ;
                part1 = Directory.GetFiles(dialog.SelectedPath , "*.png") ;
                part2 = Directory.GetFiles(dialog.SelectedPath, "*.jpg");

                folderFile = new string[part1.Length + part2.Length];
                Array.Copy(part1, 0, folderFile, 0, part1.Length);

                Array.Copy(part2, 0, folderFile, part1.Length,

                part2.Length);

                selected = 0;
                begin = 0;
                end = folderFile.Length - 1;
                showImage(folderFile[selected]);
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnStart.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextImage();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                btnStart.Text = "<< Bắt đầu Slide Show >>";
            }
            else
            {
                timer1.Enabled = true;
                btnStart.Text = "<< Kết thúc Slide Show >>";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            prevImage(); 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextImage();
        }
    }
}
