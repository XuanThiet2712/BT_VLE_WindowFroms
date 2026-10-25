using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Program
    {
        struct HangHoa
        {
            public int MaMH;
            public string TenMH;
            public int SoLuong;
            public double DonGia;

            public override string ToString()
            {
                return string.Format($"{MaMH} - {TenMH} - {SoLuong} - {DonGia}");
            }

            public double ThanhTien()
            {
                return DonGia * SoLuong; 
            }



        }

        static HangHoa ADD()
        {
            HangHoa hh = new HangHoa();
            Console.WriteLine("Nhap ma HH : ");
            hh.MaMH = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten HH : ");
            hh.TenMH = Console.ReadLine();
            Console.WriteLine("Nhap SL : ");
            hh.SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap don gia : ");
            hh.DonGia = int.Parse(Console.ReadLine());
            return hh;
        }
        static bool TimMH(List<HangHoa> ds, int ma)
        {
            foreach (HangHoa m in ds)
            {
                if (m.MaMH == ma)
                    return true;
            }
            return false;
        }

        static void XuatDS(List<HangHoa> ds)
        {
            foreach (HangHoa m in ds)
            {
                Console.WriteLine(m);
            }
        }

        static void XoaMH(List<HangHoa> ds, int ma)
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
            List<HangHoa> ds = new List<HangHoa>();

            while (true)
            {
                HangHoa hangHoa = new HangHoa();
                hangHoa = ADD();
                ds.Add(hangHoa);
                Console.WriteLine("Nhan stop de dung");
                string choice = Console.ReadLine();
                if (choice == "stop") break;
            }

            foreach (HangHoa h in ds)
                Console.WriteLine(h);

            Console.WriteLine("Nhap ma MH can tim : ");
            int x = int.Parse(Console.ReadLine());
            if(TimMH(ds, x))
            {
                XoaMH(ds, x);
               
            }

            XuatDS(ds);

        }
    }
}
