using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1: Form
    {
        private List<string> danhSach = new List<string>();
        private int viTri = -1;
        private static readonly string[] DuoiAnh = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

        private void NapDanhSach(IEnumerable<string> files, string batDau = null)
        {
            danhSach.Clear();

            foreach (string f in files)
            {
                string ext = Path.GetExtension(f).ToLower();
                if (Array.IndexOf(DuoiAnh, ext) >= 0)
                    danhSach.Add(f);
            }

            danhSach.Sort(StringComparer.OrdinalIgnoreCase);
            viTri = danhSach.Count > 0 ? 0 : -1;

            if (batDau != null)
            {
                int i = danhSach.FindIndex(x => string.Equals(x, batDau, StringComparison.OrdinalIgnoreCase));
                if (i >= 0) viTri = i;
            }
        }

        public Form1()
        {
            InitializeComponent();
            cboSizeMode.DataSource = Enum.GetValues(typeof(PictureBoxSizeMode));
            this.AllowDrop = true;
            picAnh.AllowDrop = true;

            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;
            picAnh.DragEnter += Form1_DragEnter;
            picAnh.DragDrop += Form1_DragDrop;
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;     // hiện con trỏ "được phép thả"
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (paths == null || paths.Length == 0) return;

            if (Directory.Exists(paths[0]))
            {
                NapDanhSach(Directory.GetFiles(paths[0]));            // thả cả thư mục
            }
            else if (paths.Length == 1)
            {
                string thuMuc = Path.GetDirectoryName(paths[0]);
                NapDanhSach(Directory.GetFiles(thuMuc), paths[0]);    // thả 1 ảnh: mở cả thư mục, nhảy tới ảnh đó
            }
            else
            {
                NapDanhSach(paths);                                    // thả nhiều file
            }

            HienAnh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Image DocAnh(string path)
        {
            Image img = null;
            try
            {
                img = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return img;
        }
        private void HienAnh()
        {
            // Giải phóng ảnh cũ để khỏi tốn bộ nhớ
            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }

            // Danh sách rỗng
            if (viTri < 0 || viTri >= danhSach.Count)
            {
                this.Text = "Trình xem ảnh";
                CapNhatNut();
                return;
            }

            string path = danhSach[viTri];
            try
            {
                picAnh.Image = DocAnh(path);
                this.Text = $"{Path.GetFileName(path)} ({viTri + 1}/{danhSach.Count})";
            }
            catch (Exception ex)
            {
                // File hỏng: báo lỗi, bỏ khỏi danh sách rồi hiện ảnh kế
                MessageBox.Show("Không đọc được ảnh:\n" + path + "\n" + ex.Message);
                danhSach.RemoveAt(viTri);
                if (viTri >= danhSach.Count) viTri = danhSach.Count - 1;
                
                HienAnh();
                return;
            }
            CapNhatNut();
        }
        private void CapNhatNut()
        {
            btnTruoc.Enabled = viTri > 0;                      // đang ở ảnh đầu thì khóa
            btnSau.Enabled = viTri < danhSach.Count - 1;     // đang ở ảnh cuối thì khóa
            btnXoa.Enabled = danhSach.Count > 0;
        }
        private void btnMoThuMuc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Chọn thư mục chứa ảnh";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                NapDanhSach(Directory.GetFiles(dlg.SelectedPath));

                // Tạm thời để kiểm tra: sẽ thay bằng HienAnh() ở bước 2
                //MessageBox.Show("Tìm thấy " + danhSach.Count + " ảnh");
                if (danhSach.Count == 0)
                    MessageBox.Show("Thư mục này không có ảnh!");

                HienAnh();
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (viTri > 0)
            {
                viTri--;
                HienAnh();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (viTri < danhSach.Count - 1)
            {
                viTri++;
                HienAnh();
            }
        }

        private void cboSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAnh.SizeMode = (PictureBoxSizeMode)cboSizeMode.SelectedItem;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (viTri < 0 || viTri >= danhSach.Count) return;

            danhSach.RemoveAt(viTri);                     // chỉ bỏ khỏi danh sách, KHÔNG xóa file thật

            if (viTri >= danhSach.Count)                  // vừa xóa ảnh cuối
                viTri = danhSach.Count - 1;               // lùi về ảnh trước (rỗng thì thành -1)

            HienAnh();
        }
    }
}
