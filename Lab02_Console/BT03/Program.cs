using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{

    class SinhVien
    {
        //su dung khi ko can kiem tra dieu kiet set
            public int MaSV { get;  set; }
            public string HoTen { get; set; }

            public DateTime NgaySinh { get; set; }

            public string DiaChi { get; set; }

            public string DienThoai { get; set; }

        // constructor 
        //constructor 
        public SinhVien()
        {
            MaSV = 0;
            HoTen = string.Empty;
            NgaySinh = DateTime.Today;
            DiaChi = string.Empty;
            DienThoai = string.Empty;

        }

        public SinhVien(int maSV, string hoten, DateTime ngaySinh, string diaChi, string dienThoai)
        {
            MaSV = maSV;
            HoTen = hoten;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        public int Tuoi
        {
            get { return DateTime.Now.Year - NgaySinh.Year; }
        }

        public override string ToString()
        {
            return $"{MaSV} - {HoTen} - {NgaySinh:dd/MM/yyyy} - {Tuoi} tuoi - {DiaChi} - {DienThoai}";
        }
    }


    class HinhChuNhat
    {
        public double mChieuRong { get; set; }
        public double mChieuCao { get; set; }
        public HinhChuNhat()
        {
            mChieuCao = 0;
            mChieuRong = 0;
        }

        public HinhChuNhat(double r, double cao)
        {
            mChieuRong = r;
            mChieuCao = cao;
     
        }

        public double ChuVi()
        {
            return (mChieuRong + mChieuCao) * 2 ;
        }
        public double DienTich()
        {
            return mChieuRong * mChieuCao;
        }

        public bool IsSquare()
        {
            return mChieuRong == mChieuCao;
        }
    }

    //sp
    class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public double GiaSP { get; set; }

        public SanPham()
        {
            MaSP = 0;
            TenSP = string.Empty;
            GiaSP = 0;
        }
        public SanPham(int maSP, string tenSp, double giaSP)
        {
            MaSP = maSP;
            TenSP = tenSp;
            GiaSP = giaSP;
        }
        public double TinhVAT()
        {
            return GiaSP * 0.1;
        }

        public void Nhap()
        {
            Console.Write("Nhap ma: ");
            int ma; 
            while (!int.TryParse(Console.ReadLine(), out ma))
                Console.Write("Phai la so nguyen, nhap lai: ");
            MaSP = ma;

            Console.Write("Nhap ten: ");
            TenSP = Console.ReadLine();

            Console.Write("Nhap gia: ");
            double gia;
            while (!double.TryParse(Console.ReadLine(), out gia) || gia < 0)
                Console.Write("Phai la so khong am, nhap lai: ");
            GiaSP = gia;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma: " + MaSP);
            Console.WriteLine("Ten: " + TenSP);
            Console.WriteLine("Gia: " + GiaSP);
            Console.WriteLine("Thue VAT: " + TinhVAT());
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            dssv.Add(new SinhVien
            {
                MaSV = 1,
                HoTen = "Tran Van Teo",
                DienThoai = "0909789567",
                DiaChi = "123 Truong Dinh",
                NgaySinh = new DateTime(2000, 11, 28)
            });
            dssv.Add(new SinhVien
            {
                MaSV = 2,
                HoTen = "Tran Van Quang",
                DienThoai = "0909567789",
                DiaChi = "123 Truong Cong Dinh",
                NgaySinh = new DateTime(1999, 11, 28)
            });
            foreach (SinhVien sv in dssv)
            {
                Console.WriteLine(sv);
            }

            //hcn
            HinhChuNhat hcm = new HinhChuNhat(4, 6);
            Console.WriteLine(hcm.ChuVi());
            Console.WriteLine(hcm.DienTich());
            Console.WriteLine(hcm.IsSquare());

            //sp
      
            SanPham sp1 = new SanPham();
            SanPham sp2 = new SanPham();

            Console.WriteLine("Nhap san pham 1");
            sp1.Nhap();
            Console.WriteLine("Nhap san pham 2");
            sp2.Nhap();

            // Gọi phương thức xuất
            Console.WriteLine("\n--- San pham 1");
            sp1.Xuat();
            Console.WriteLine("\n--- San pham 2");
            sp2.Xuat();

            Console.ReadKey();

        }
    }
}
