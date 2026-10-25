using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    class NhanVien : Nguoi
    {
        public string MaNhanVien { get; set; }
        public string Email { get; set; }

        public string DienThoai { get; set; }
        public DateTime NgayLamViec { get; set; }

        public string MaCongTy {  get; set; }

        //constructor 

        public NhanVien() : base() 
        { 
            MaNhanVien = string.Empty;
            Email = string.Empty;
            DienThoai = string.Empty;
            MaCongTy = string.Empty;
            NgayLamViec = DateTime.MinValue;
           
        }

        public NhanVien(string hoTen, DateTime ngaySinh, string diaChi,string maNhanVien , string email , string dienThoai, DateTime ngayLamViec , string maCongTy)
            : base (hoTen , ngaySinh, diaChi)
        {
            MaNhanVien= maNhanVien;
            Email= email;
            DienThoai= dienThoai;
            MaCongTy= maCongTy;
            NgayLamViec= ngayLamViec;
        }

        public override void XemThongTin()
        {
            base.XemThongTin();
            Console.WriteLine("Ma nhan vien : " + MaNhanVien);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Ngay lam viec : " + NgayLamViec);
            Console.WriteLine("Ma cong ty : " + MaCongTy);
            Console.WriteLine("Dien thoai : " + DienThoai);
        }
    }
}
