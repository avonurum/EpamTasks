using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop27
{
    //найти площадь
    //    периметр
    //    сторону а
    //    сторону б
    //для данного класса координа начала начало диагонали прямоугольника, а конечная - конец диагонали прямоугольника.
    class Rectangle : Figure
    {
        private double diagonal;
        private double a;
        private double b;
        public Rectangle(string color, double x1, double y1, double x2, double y2) : base(color, x1, y1, x2, y2)
        {
            Color = color;
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
            Diagonal = DistanceBetweenPoints;
        }



        public double Diagonal { get => diagonal;private set => diagonal = value; }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
