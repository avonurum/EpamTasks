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
        public Line(string color, double x1, double y1, double x2, double y2) : base(color, x1, y1, x2, y2)
        {
            Color = color;
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
            Length = DistanceBetweenPoints;
        }

        public double Length { get => length;private set => length = value; }

        public override void Print()
        {
            Console.WriteLine($"Фигура:{this.GetType().Name}\n Длина:{length}\n Координаты:{{{Start.X},{Start.Y};{Finish.X},{Finish.Y}}}\n Цвет:{Color}");
        }
    }
}
