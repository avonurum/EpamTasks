using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Oop26
{
    class Round
    {
        private double radius;

        public Round(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => radius;
            set
            {
                if (value > 0) radius = value;
                else throw new ArgumentException("Радиус окружности не может быть меньше нуля и равняться нулю");
            }
        }


        public double Area => PI * Radius * Radius;

        public double Length => 2 * PI * Radius;

        
    }
}
