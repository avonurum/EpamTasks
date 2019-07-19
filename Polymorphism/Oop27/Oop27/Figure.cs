using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop27
{
    /* Каждый потомок данного класса будет иметь координаты начала и конца.*/
    abstract class Figure
    {
        private Point start;
        private Point finish;

        protected Figure(double x1, double y1, double x2, double y2)
        {
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
        }
        protected Point Start { get => start; set => start = value; }
        protected Point Finish { get => finish; set => finish = value; }
        abstract public void Print(); //демонстрация фигуры
        public abstract double DistanceBetweenPoints();//подсчет растояния между наxальной и конечной точкой;
    }
}
