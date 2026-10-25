using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            // P = 1 + 2x + 3x^2
            DaThuc p = new DaThuc(2);
            p[0] = 1; p[1] = 2; p[2] = 3;

            // Q = 4 - x + 5x^3
            DaThuc q = new DaThuc(3);
            q[0] = 4; q[1] = -1; q[3] = 5;

            Console.WriteLine("P(x) = " + p + "   (bac " + p.Bac + ")");
            Console.WriteLine("Q(x) = " + q + "   (bac " + q.Bac + ")");
            Console.WriteLine("P + Q = " + (p + q));
            Console.WriteLine("P - Q = " + (p - q));
            Console.WriteLine("P(2) = " + p.TinhGiaTri(2));   
            // 1+4+12 = 17
            Console.WriteLine("a1 cua P = " + p[1]);

            Console.ReadKey();
        }
    }
}
