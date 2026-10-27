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
using System.ComponentModel;

namespace bai5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KetQua(Control c, string loi, CancelEventArgs e)
        {
            errorProvider1.SetError(c, loi);
            e.Cancel = loi.Length > 0;      // có lỗi thì giữ người dùng lại ô này
        }


        private void btnChonAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string s = txtEmail.Text.Trim();
            string loi = "";

            int at = s.IndexOf('@');
            int cham = (at >= 0) ? s.IndexOf('.', at + 1) : -1;

            if (s == "")
                loi = "Email không được để trống";
            else if (at <= 0 || at != s.LastIndexOf('@') || cham <= at + 1 || cham >= s.Length - 1)
                loi = "Email không hợp lệ (ví dụ: ten@gmail.com)";

            KetQua(txtEmail, loi, e);
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            string ten = txtHoTen.Text.Trim();
            string loi = "";

            if (ten == "")
                loi = "Họ tên không được để trống";
            else if (ten.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length < 2)
                loi = "Họ tên phải có ít nhất 2 từ";

            KetQua(txtHoTen, loi, e);
        }

        private void txtTuoi_Validating(object sender, CancelEventArgs e)
        {
            string loi = "";

            if (!int.TryParse(txtTuoi.Text.Trim(), out int tuoi))
                loi = "Tuổi phải là một số nguyên";
            else if (tuoi < 1 || tuoi > 120)
                loi = "Tuổi phải từ 1 đến 120";

            KetQua(txtTuoi, loi, e);
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            string loi = (txtMatKhau.Text.Length < 6) ? "Mật khẩu phải có ít nhất 6 ký tự" : "";
            KetQua(txtMatKhau, loi, e);
        }

        private void txtNhapLai_Validating(object sender, CancelEventArgs e)
        {
            string loi = (txtNhapLai.Text != txtMatKhau.Text) ? "Hai mật khẩu không khớp" : "";
            KetQua(txtNhapLai, loi, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
