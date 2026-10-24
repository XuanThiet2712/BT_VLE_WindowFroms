using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Baitap4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1. Nhap ho ten lot ho ten, xuat ra ho ten day du ");
            Console.WriteLine("2. Nhap ho ten day du, xuat ra tung phan ho tenlot ten ");
            Console.WriteLine("3. Nhap ho ten ko dung cu phap, xuat ra dang hoan chinh");
            Console.WriteLine("Moi ban nhap lua chon : ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
                Console.WriteLine("lua chon ko hop le, nhap lai :");
            switch (choice)
            {
                case 1:
                    NhapHoTen();
                    break;
                case 2:
                    NhapTenDayDu();
                    break;
                case 3:
                    XuatTenHoanChinh();
                    break;
                default:
                    Console.WriteLine("Loi");
                    break;

            }
        }
        static void NhapHoTen()
        {
            string ho, tenlot, ten;
            Console.WriteLine("Nhap ho :");
            ho = Console.ReadLine();
            Console.WriteLine("Nhap ten lot : ");
            tenlot = Console.ReadLine();
            Console.WriteLine("Nhap ten : ");
            ten = Console.ReadLine();
            Console.WriteLine("Ho ten day du : " + ho + tenlot + ten);
        }
        static void NhapTenDayDu()
        {
            string name;
    
            name = Console.ReadLine();
            string[] splitName = name.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Ho la : " + splitName[0]);
            Console.WriteLine("Ten lot la : ");
            for (int i = 1; i < splitName.Length - 1; i++)
                Console.Write(splitName[i] + " ");
            Console.WriteLine("Ten la : " + splitName[splitName.Length - 1]);
        }
        static void XuatTenHoanChinh()
        {
            Console.WriteLine("Nhap ho ten day du :");
            string fullName = Console.ReadLine();
            fullName = fullName.Trim();
            string[] right = fullName.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string x in right)
                Console.Write(x + " ");
        }
    }
}
