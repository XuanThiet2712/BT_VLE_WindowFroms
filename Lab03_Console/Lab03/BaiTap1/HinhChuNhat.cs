using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class HinhChuNhat : HinhHoc
    {
        public double mChieuDai { get; set; }
        public double mChieuRong { get; set; }

        public HinhChuNhat() 
            {
            mChieuDai = 0;
            mChieuRong = 0;

            }
        public HinhChuNhat(double mChieuDai, double mChieuRong)
        {
            this.mChieuDai = mChieuDai;
            this.mChieuRong = mChieuRong;
        }

        public override void tinhChuVi()
        {
            ChuVi = (mChieuDai + mChieuRong) * 2 ;
        }
        public override void tinhDienTich()
        {
            DienTich = mChieuRong * mChieuDai;
        }

        public override string ToString()
        {
            return "Hinh chu nhat : " + base.ToString();
        }
    }
}
