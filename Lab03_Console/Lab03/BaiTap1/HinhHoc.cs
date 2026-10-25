using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    public class HinhHoc
    {
        public double ChuVi { get; set; }
        public double DienTich { get; set; }

        public HinhHoc()
        {
            ChuVi = 0; DienTich = 0;
        }
        public virtual void tinhChuVi()
        {

        }
        public virtual void tinhDienTich() { }

        public override string ToString()
        {
            return $"Chu vi : {ChuVi} - Dien tich : {DienTich}";
        }
    }
}
