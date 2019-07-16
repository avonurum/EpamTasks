using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop27
{
    /*Для класса круг коррдината начала - середина, а конца - это одна из точек на границе круга, а расстояние между началом и концом - радиус круга.*/
    class Round : Figure
    {
        private double radius;

        public Round(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
            Radius = DistanceBetweenPoints();
        }

        public double Radius { get => radius; private set => radius = value; }

        public double Area => Math.PI * Radius * Radius;

        public override void Print()
        {
            Console.WriteLine($"Фигура:{this.GetType().Name}\n Радиус:{radius}\n Площадь:{Area}" +
                $"Координаты:{{{Start.X},{Start.Y};{Finish.X},{Finish.Y}}}");
        }
        public override double DistanceBetweenPoints()
        {
            double value1 = Math.Sqrt((Finish.X - Start.X) * (Finish.X - Start.X) + (Finish.Y - Start.Y) * (Finish.Y - Start.Y));
            if (value1 > 0)
            {
                return value1;
            }
            else
            {
                throw new ArgumentException("Радиус не может быть меньше нуля");
            }
        }
    }
}
