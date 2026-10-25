using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{

        class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat(4, 9);
            HinhTron hinhtron = new HinhTron(5);
            hinhChuNhat.tinhDienTich();
            hinhChuNhat.tinhChuVi();
            hinhtron.tinhChuVi();
            hinhtron.tinhDienTich();
            Console.WriteLine(hinhtron);
            Console.WriteLine(hinhChuNhat);
        }
    }
}
