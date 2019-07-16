using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop27
{
    //создание фигуры
    //вывод фигур
    //добавление фигур в лист
    //вывод возможных цветов и фигур
    class Program
    {
        static void Main(string[] args)
        {
            List <Figure> list = new List <Figure>();
            list.Add(new Line("Зеленый", 0, 0, 1, 1));
            list.Add(new Line("Красный", 2, 2, 1, 1));
            list.Add(new Line("Белый", 3, 3, 1, 3));
            foreach(Figure f  in list)
            {
               f.Print();
            }
            Console.ReadLine();
            //foreach (ColorsOfFigure c in Enum.GetValues(typeof(ColorsOfFigure)))
            //{
            //    Console.WriteLine(c);
            //}
        }
    }
}
