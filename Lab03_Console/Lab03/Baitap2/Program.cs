using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // test lop nguoi
            Console.WriteLine("TEST LOP NGUOI");

            Console.WriteLine("\n[Constructor khong tham so]");
            Nguoi n1 = new Nguoi();
            n1.XemThongTin();

            Console.WriteLine("\n[Constructor co tham so]");
            Nguoi n2 = new Nguoi("Nguyen Van A", new DateTime(2000, 5, 20), "123 Le Loi, Q1");
            n2.XemThongTin();

            Console.WriteLine("\n[Test properties get/set]");
            n1.HoTen = "Tran Thi B";
            n1.NgaySinh = new DateTime(1998, 12, 1);
            n1.DiaChi = "45 Hai Ba Trung";
            Console.WriteLine("HoTen   = " + n1.HoTen);
            Console.WriteLine("NgaySinh= " + n1.NgaySinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("DiaChi  = " + n1.DiaChi);
            Console.WriteLine("LayTuoi = " + n1.tuoi);

            // Test lớp SinhVien
            Console.WriteLine("\n TEST LOP SINHVIEN ");

            Console.WriteLine("\n[Constructor khong tham so]");
            SinhVien sv1 = new SinhVien();
            sv1.XemThongTin();

            Console.WriteLine("\n[Constructor co tham so]");
            SinhVien sv2 = new SinhVien("Le Van C", new DateTime(2003, 9, 15), "TP.HCM",
                                        "SV001", "CNTT01", "levanc@gmail.com", "0901234567");
            sv2.XemThongTin();

            Console.WriteLine("\n[Gan lai qua properties]");
            sv1.HoTen = "Pham Thi D";
            sv1.NgaySinh = new DateTime(2002, 1, 10);
            sv1.DiaChi = "Binh Thanh";
            sv1.MaSV = "SV002";
            sv1.MaLop = "CNTT02";
            sv1.Email = "phamthid@gmail.com";
            sv1.DienThoai = "0987654321";
            sv1.XemThongTin();

            //Test lớp NhanVien 
            Console.WriteLine("\n TEST LOP NHANVIEN");

            Console.WriteLine("\n[Constructor khong tham so]");
            NhanVien nv1 = new NhanVien();
            nv1.XemThongTin();

            Console.WriteLine("\n[Constructor co tham so]");
            NhanVien nv2 = new NhanVien("Hoang Van E", new DateTime(1995, 3, 8), "Thu Duc",
                                        "NV001", "hoangvane@congty.com", "0912345678",
                                        new DateTime(2020, 6, 1), "CT01");
            nv2.XemThongTin();

            Console.WriteLine("\n[Gan lai qua properties]");
            nv1.HoTen = "Vo Thi F";
            nv1.NgaySinh = new DateTime(1990, 7, 25);
            nv1.MaNhanVien = "NV002";
            nv1.Email = "vothif@congty.com";
            nv1.DienThoai = "0933333333";
            nv1.NgayLamViec = new DateTime(2018, 2, 12);
            nv1.MaCongTy = "CT02";
            nv1.XemThongTin();

            // Test tính đa hình
            Console.WriteLine("\nTEST DA HINH");
            Nguoi[] ds = { n2, sv2, nv2 };
            foreach (Nguoi n in ds)
            {
                Console.WriteLine("\n" + n.GetType().Name + "");
                n.XemThongTin();          // gọi đúng phiên bản của từng lớp
            }

            Console.ReadKey();
        }
    }
}
