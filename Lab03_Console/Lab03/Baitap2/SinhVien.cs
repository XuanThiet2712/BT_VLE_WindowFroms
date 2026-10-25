using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    public class SinhVien : Nguoi
    {
        public string MaSV { get; set; }
        public string MaLop { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }

        //constructor

        public SinhVien() : base() 
        {
            MaSV = string.Empty;
            MaLop = string.Empty;
            Email = string.Empty;
            DienThoai = string.Empty;
        }

        public SinhVien(string hoTen , DateTime ngaySinh , string diaChi ,string maSV, string maLop, string email, string dienThoai) : base(hoTen, ngaySinh, diaChi)
        {
            MaSV = maSV;
            MaLop = maLop;
            Email = email;
            DienThoai = dienThoai;
        }

        public override void XemThongTin()
        {
            base.XemThongTin();
            Console.WriteLine("Ma sinh vien : " + MaSV);
            Console.WriteLine("Ma lop : " + MaLop);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Dien thoai : " + DienThoai);
        }
    }
}
