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
            Console.WriteLine("Moi ban nhap n phan tu ngau nhien : ");
            int n; 
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.WriteLine("Yeu cau nhap chu so nguyen");
            Random rd = new Random();
            List<int> lst = new List<int>();
            for(int i = 0; i < n; i++)
            {
                lst.Add(rd.Next(0, 101));
            }
            foreach (int x in lst)
                Console.Write(x + " ");
        }
    }
}
