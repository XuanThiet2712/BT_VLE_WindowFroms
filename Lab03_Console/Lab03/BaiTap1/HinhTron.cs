using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    public class HinhTron : HinhHoc
    {
        public double mBanKinh { get; set; }
        public HinhTron(double mBanKinh = 0)
        {
            this.mBanKinh = mBanKinh;
        }

        public override void tinhDienTich()
        {
            ChuVi = Math.PI * Math.PI * mBanKinh ;
        }

        public override void tinhChuVi()
        {
            DienTich = Math.PI * 2 * mBanKinh;
        }

        public override string ToString()
        {
            return "Hinh Tron : " + base.ToString();
        }
    }
}
