using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{

    class NotNegativeException : Exception
    {
        public NotNegativeException(string message) : base(message) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen X ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen Y");
            int y = int.Parse(Console.ReadLine());

            try
            {
                int mau = (2 * x - y);
                if (mau == 0)
                {
                    throw new DivideByZeroException();
                }
                double giaTri = (3.0 * x + 2 * y) / mau;
                if (giaTri < 0)
                {
                    throw new NotNegativeException("Gia tri duoi canh bi am");
                }

                double H = Math.Sqrt(giaTri);
                Console.WriteLine("H = " + H);
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi dinh dang");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Loi ko chia het cho 0");
            }
            catch (NotNegativeException e )
            {
                Console.WriteLine("Loi" + e.Message);
            }
            Console.ReadLine();
        }
    }
}

