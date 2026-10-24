using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n;
            int min, max; 
            Console.WriteLine("Moi ban nhap so luong phan tu cua mang :");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("cu phap ko hop le, nhap lai");
                }
                else
                {
                    break;
                }
            }

            int[] arr = new int[n];
            Console.WriteLine("Moi nhap {0} phan tu trong mang", n);
            for(int i =0; i < n; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    Console.Write("Cu phap ko hop le, nhap lai : ");
            }
            min = arr[0];
            max = arr[0];
            sum = arr[0];
            for(int i = 1; i < n; i++)
            {
                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
                sum += arr[i];
            }
            Console.WriteLine();
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.Write(sum);
        }
    }
}
