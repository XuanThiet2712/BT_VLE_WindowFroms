using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan1b
{
    class Program
    {
        static void Main(string[] args)
        {
            DuongTron dt = new DuongTron();
            dt.Xuat();
            Console.WriteLine();
            Diem point = new Diem(1, 3);
            DuongTron dt2 = new DuongTron(point, 10);
            dt2.Xuat();
            Console.WriteLine();
            DuongTron dt3 = new DuongTron(dt2);
            dt3.Xuat();
            Console.WriteLine();
            double chuVi = dt2.ChuVi();
            Console.WriteLine("Chu vi duong tron:" + chuVi);
        }
    }
}
