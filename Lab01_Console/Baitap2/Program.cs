using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //giai pt bac 1
            try
            {
                Console.WriteLine("Moi nhap lan luot 2 tham so a va b cho pt ax + b = 0 ");
                double a, b;
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    if (b == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    else
                        Console.WriteLine("Pt vo nghiem");
                }
                else
                    Console.WriteLine("PT co nghiem x = " + (-b / a));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Loi : {ex.Message}");
            }
        }
    }
}
