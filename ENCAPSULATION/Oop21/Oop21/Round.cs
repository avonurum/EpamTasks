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
        private double x;
        private double y;
        private double radius;

        public Round(double x,double y,double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public double Radius
        {
            get => radius;
            set
            {
                if(value>0)
                    radius = value;
                else
                    throw new ArgumentException("Радиус не может являться отрицальным числом или равняться нулю.");
            }
        }
        public double Area { get => PI * radius * radius; }
        public double Circumference { get => 2 * PI * radius; } //длина окружности
    }
}
