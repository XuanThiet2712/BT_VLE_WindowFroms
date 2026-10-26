using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan1b
{
    class DuongTron
    {
        private Diem tam;
        private int banKinh;
        internal Diem Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        public int BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }

        // Phương thức khởi tạo mặc định
        public DuongTron()
        {
            tam = new Diem();
            banKinh = 0;
        }

        // Phương thức khởi tạo khi biết đầy đủ thông tin

        public DuongTron(Diem t, int r)
        {
            Tam = t;
            BanKinh = r;
        }
        // Phương thức khởi tạo sao chép
        public DuongTron(DuongTron dt)
        {
            Tam = dt.Tam;
            BanKinh = dt.BanKinh;
        }

        public double ChuVi()
        {
            double cv;
            cv = 2 * Math.PI * BanKinh * BanKinh; // 2*pi*r*r
            return cv;
        }

        public void Xuat()
        {
            Console.Write("(" + tam.ToString() + ", " + banKinh + ")");
        }
    }
}
