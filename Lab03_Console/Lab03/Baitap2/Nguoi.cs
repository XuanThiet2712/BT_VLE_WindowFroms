using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    public class Nguoi
    {
        public string HoTen {  get; set; }
        public DateTime NgaySinh { get; set; }

        public string DiaChi { get; set; }

        //constructor 
        public Nguoi()
        {
            HoTen = string.Empty;
            NgaySinh = DateTime.Now;
            DiaChi = string.Empty;
        }

        public Nguoi(string hoTen, DateTime ngaySinh, string diaChi)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }

        public int tuoi { get { return DateTime.Now.Year - NgaySinh.Year; } }

        public virtual void XemThongTin()
        {
            Console.WriteLine("Ho ten : " + HoTen);
            Console.WriteLine("Ngay Sinh : " + NgaySinh);
            Console.WriteLine("Tuoi : " + tuoi);
            Console.WriteLine("DiaChi : " + DiaChi);
        }

    }
}
