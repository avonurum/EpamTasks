using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Oop21
{
    class Round
    {
        private int x;
        private int y;
        private int radius;

        public Round(int x,int y,int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if(value>0)
                    radius = value;
                else
                    throw new ArgumentException("Радиус не может являться отрицальным числом или равняться нулю.");
            }
        }
        public double Area { get => PI * radius * radius; }
        public double Circumference { get => 2 * PI * radius; }
    }
}
