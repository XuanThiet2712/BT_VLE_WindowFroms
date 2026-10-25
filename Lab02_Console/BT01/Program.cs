using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstHH = new List<string>();
            while(true)
            {
                Console.WriteLine("Moi ban nhap ten hang hoa , nhap Stop de dung ");
                string s = Console.ReadLine();
                if (s == "Stop") break;
                lstHH.Add(s);
            }
            foreach (string s in lstHH)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Moi nhap ten hang hoa can tim ");
            string findHH = Console.ReadLine();
            Console.WriteLine(lstHH.Contains(findHH));

            // xoa
            Console.WriteLine("Nhap hang hoa ban muon xoa");
            int delHH;
            while (!int.TryParse(Console.ReadLine(), out delHH))
                Console.WriteLine("Nhap lai ");
            lstHH.RemoveAt(delHH);

            foreach (string s in lstHH)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Nhap hang ban muon them");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap hang hoa ban muon them o cot {0}", x);
            string ss = Console.ReadLine();
            lstHH.Insert(x, ss);
            foreach (string s in lstHH)
            {
                Console.WriteLine(s);
            }
        }
    }
}
