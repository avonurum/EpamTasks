using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Oop27
{
    /* для данного класса коррдината начала - это середина кольца, а конечная - одна из точек на внутреннем радиусе кольца. Внешний радиус 
     * вычисляется автоматически*/
    class Ring : Figure
    {
        private double innerR;
        private double outerR;
        public Ring(string color, double x1, double y1, double x2, double y2) : base(color, x1, y1, x2, y2)
        {
            Color = color;
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
            InnerR = DistanceBetweenPoints;
            outerR = InnerR + InnerR * 0.3;
        }

        public double InnerR { get => innerR;private set => innerR = value; }
        public double OuterR { get => outerR; private set => outerR = value; }



        public override void Print()
        {
            Console.WriteLine($"Фигура:{this.GetType().Name}\n Внутренний радиус:{innerR}\n Внешний радиус:{outerR}\n Площадь:{Area}" +
                $"Координаты:{{{Start.X},{Start.Y};{Finish.X},{Finish.Y}}}\n Цвет:{Color}");
        }
        public double Area => PI*(outerR*outerR-innerR*innerR);  
    }
}
