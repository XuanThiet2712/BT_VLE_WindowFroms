using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Program
    {
        struct MatHang
        {
            public int MaMH;
            public string TenMH;
            public int SoLuong;
            public double DonGia;

            // constructor
            public MatHang(int ma, string ten, int sl, double gia)
            {
                MaMH = ma;
                TenMH = ten;
                SoLuong = sl;
                DonGia = gia;
            }

            // Hàm tính thành tiền
            public double ThanhTien()
            {
                return SoLuong * DonGia;
            }
        }

        // Thêm một mặt hàng vào danh sách
        static void ThemMH(List<MatHang> ds, MatHang mh)
        {
            ds.Add(mh);
        }

        // Tìm mặt hàng theo mã
        static bool TimMH(List<MatHang> ds, int ma)
        {
            foreach (MatHang m in ds)
            {
                if (m.MaMH == ma)
                    return true;
            }
            return false;
        }

        // Xuất danh sách
        static void XuatDS(List<MatHang> ds)
        {
            foreach (MatHang m in ds)
            {
                Console.WriteLine("Ma: " + m.MaMH
                    + " | Ten: " + m.TenMH
                    + " | SL: " + m.SoLuong
                    + " | Don gia: " + m.DonGia
                    + " | Thanh tien: " + m.ThanhTien());
            }
        }

        // Xóa mặt hàng theo mã
        static void XoaMH(List<MatHang> ds, int ma)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaMH == ma)
                {
                    ds.RemoveAt(i);
                    return;            
                }
            }
        }

        static void Main(string[] args)
        {
            List<MatHang> ds = new List<MatHang>();
            string tiep;

            //  Nhập danh sách
            do
            {
                Console.Write("Nhap ma: ");
                int ma = int.Parse(Console.ReadLine());

                Console.Write("Nhap ten: ");
                string ten = Console.ReadLine();

                Console.Write("Nhap so luong: ");
                int sl = int.Parse(Console.ReadLine());

                Console.Write("Nhap don gia: ");
                double gia = double.Parse(Console.ReadLine());

                ThemMH(ds, new MatHang(ma, ten, sl, gia));

                Console.Write("Tiep tuc nhap? (c/k): ");
                tiep = Console.ReadLine();
            } while (tiep == "c");

            //  Xuất danh sách
            Console.WriteLine("--- DANH SACH ---");
            XuatDS(ds);

            // 3 Tìm, xóa, xuất lại
            Console.Write("Nhap ma can tim: ");
            int maXoa = int.Parse(Console.ReadLine());

            if (TimMH(ds, maXoa))
            {
                Console.WriteLine("Tim thay, dang xoa...");
                XoaMH(ds, maXoa);
                Console.WriteLine("--- DANH SACH SAU KHI XOA ---");
                XuatDS(ds);
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
        }
    }
}