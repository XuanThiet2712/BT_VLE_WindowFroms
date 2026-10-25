using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    public class DaThuc
    {
        private double[] heSo; 
        public DaThuc(int bac)
        {
            if (bac < 0)
                throw new ArgumentException("Bac phai >= 0");
            heSo = new double[bac + 1];   
        }

        // Property cho biết bậc n
        public int Bac
        {
            get { return heSo.Length - 1; }
        }

        public double this[int k]
        {
            get
            {
                if (k < 0 || k > Bac)
                    throw new IndexOutOfRangeException("k phai tu 0 den " + Bac);
                return heSo[k];
            }
            set
            {
                if (k < 0 || k > Bac)
                    throw new IndexOutOfRangeException("k phai tu 0 den " + Bac);
                heSo[k] = value;
            }
        }

        // Phép cộng
        public static DaThuc operator + (DaThuc a, DaThuc b)
        {
            int bacMax = Math.Max(a.Bac, b.Bac);
            DaThuc kq = new DaThuc(bacMax);
            for (int k = 0; k <= bacMax; k++)
            {             
                double ak = (k <= a.Bac ? a[k] : 0);
                double bk = (k <= b.Bac ? b[k] : 0);
                kq[k] = ak + bk;
            }
            return kq;
        }

        // Phép trừ
        public static DaThuc operator - (DaThuc a, DaThuc b)
        {
            int bacMax = Math.Max(a.Bac, b.Bac);
            DaThuc kq = new DaThuc(bacMax);
            for (int k = 0; k <= bacMax; k++)
            {
                double ak = (k <= a.Bac ? a[k] : 0);
                double bk = (k <= b.Bac ? b[k] : 0);
                kq[k] = ak - bk;
            }
            return kq;
        }


        public double TinhGiaTri(double b)
        {
            double kq = 0;
            for (int k = Bac; k >= 0; k--)
                kq = kq * b + heSo[k];
            return kq;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int k = Bac; k >= 0; k--)
            {
                if (heSo[k] == 0) continue;
                if (sb.Length > 0)
                    sb.Append(heSo[k] > 0 ? " + " : " - ");
                else if (heSo[k] < 0)
                    sb.Append("-");

                sb.Append(Math.Abs(heSo[k]));
                if (k >= 1) sb.Append("x");
                if (k >= 2) sb.Append("^" + k);
            }
            return sb.Length == 0 ? "0" : sb.ToString();
        }
    }
}
