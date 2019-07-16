using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop27
{
    /* Каждый потомок данного класса будет иметь координаты начала и конца.*/
    enum ColorsOfFigure
    {
        Красный=0,
        Желтый = 1,
        Синий = 2,
        Фиолетовый = 3,
        Оранжевый = 4,
        Голубой = 5,
        Зеленый = 6,
        Черный = 7,
        Белый =8
    }
    abstract class Figure
    {
        private string color;
        private Point start;
        private Point finish;
        private double distanceBetweenPoints;

        protected Figure(string color,double x1, double y1, double x2, double y2)
        {
            Color = color;
            Start = new Point(x1, y1);
            Finish = new Point(x2, y2);
        }

        public string Color {
            get => color.ToString();
            set
            {
                
                foreach (ColorsOfFigure c in Enum.GetValues(typeof(ColorsOfFigure)))
                {
                    if (c.ToString().Equals(value))
                    {
                        color = value;
                    }
                }
                if (color == null)
                {
                    throw new ArgumentException("Вы ввели несуществующий цвет");
                }
            }   
        }

        protected Point Start { get => start; set => start = value; }
        protected Point Finish { get => finish; set => finish = value; }
        abstract public void Print(); //демонстрация фигуры
        public double DistanceBetweenPoints
        {
            get
            {
                return distanceBetweenPoints;
            }
            private set
            {
                double value1=Math.Sqrt((Finish.X - Start.X) * (Finish.X - Start.X) + (Finish.Y - Start.Y) * (Finish.Y - Start.Y));
                if(value1>0)
                {
                    distanceBetweenPoints = value1;
                }
            }
        }
            //подсчет растояния между наальной и конечной точкой;

    }
}
