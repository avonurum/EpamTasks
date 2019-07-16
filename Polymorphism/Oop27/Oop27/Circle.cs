using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop27
{
    /*Для класса окружность координата начала - середина, а конца - это одна из точек на границе круга, а расстояние между началом и концом - радиус окружности.*/
    class Circle : Figure
    {
        private double radius;
        public Circle(double x1, double y1, double x2, double y2) : base( x1, y1, x2, y2)
        {
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
            Radius = DistanceBetweenPoints();
        }

        public double Radius { get => radius;private set => radius = value; }

        public double Length => 2*Math.PI * Radius;

        public override void Print()
        {
            Console.WriteLine($"Фигура:{this.GetType().Name}\n Радиус:{radius}\n Длина:{Length}" +
                $"Координаты:{{{Start.X},{Start.Y};{Finish.X},{Finish.Y}}}\n ");
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
