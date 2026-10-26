using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan1b
{
    public class Diem
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }       
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Diem()
        {
            x = 0;
            y = 0;
        }
        public Diem(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public Diem(Diem p)
        {
            X = p.X;
            Y = p.Y;
        }
        // ...
        public double KhoangCach(Diem b)
        {
            double dx = b.X - x;
            double dy = b.Y - y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}

