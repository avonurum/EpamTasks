using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop27
{
    /*начальная точка - начало линии, конечная - ее конец*/
    class Line : Figure
    {
        private double length;
        public Line(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
            Length = DistanceBetweenPoints();
        }

        public double Length { get => length; private set => length = value; }

        public override void Print()
        {
            Console.WriteLine($"Фигура:{this.GetType().Name}\n Длина:{length}\n Координаты:{{{Start.X},{Start.Y};{Finish.X},{Finish.Y}}}");
        }
        public override double DistanceBetweenPoints()
            {
                double value1 = Math.Sqrt((Finish.X - Start.X) * (Finish.X - Start.X) + (Finish.Y - Start.Y) * (Finish.Y - Start.Y));
                if(value1>0)
                {
                   return value1;
                }
                else
                {
                    throw new ArgumentException("Длина отрезка не может быть меньше нуля");
            }
            }
    }
}
