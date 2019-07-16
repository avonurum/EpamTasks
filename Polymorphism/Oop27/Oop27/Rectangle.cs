using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop27
{
 
    //для данного класса координа начала начало диагонали прямоугольника, а конечная - конец диагонали прямоугольника.
    class Rectangle : Figure
    {
        private double diagonal;
        private double a;
        private double b;
        public Rectangle(double x1, double y1, double x2, double y2) : base( x1, y1, x2, y2)
        {
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
            Diagonal = DistanceBetweenPoints();
            A = AddBorder(x1, y1, x1, y2);
            B = AddBorder(x1, y1, x2, y1);
        }



        public double Diagonal { get => diagonal;private set => diagonal = value; }
        public double A { get => a;private set => a = value; }
        public double B { get => b;private set => b = value; }

        public override void Print()
        {
            Console.WriteLine( $"Фигура:{this.GetType().Name}\n Диагональ:{Diagonal}\n Сторона А:{A}\n Сторона B:{B}" +
                $"Координаты:{{{Start.X},{Start.Y};{Finish.X},{Finish.Y}}}\n Площадь:{Area}\n Периметр:{Perimeter}");
        }
        private double AddBorder(double x1, double y1, double x2, double y2)
        {
            double res = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            if (res > 0) return res;
            else throw new ArgumentException("Сторона прямоугольника не может быть равна нулю");
        }
        public double Area => a*b;
        public double Perimeter => (a+b)*2;
        public override double DistanceBetweenPoints()
        {
            double value1 = Math.Sqrt((Finish.X - Start.X) * (Finish.X - Start.X) + (Finish.Y - Start.Y) * (Finish.Y - Start.Y));
            if (value1 > 0)
            {
                return value1;
            }
            else
            {
                throw new ArgumentException("Диагональ не может быть меньше нуля");
            }
        }
    }
}
