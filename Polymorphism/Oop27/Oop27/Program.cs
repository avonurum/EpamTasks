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
        static bool status = true;
        static List<Figure> list = new List<Figure>();
        static Random r = new Random();
        static int randomMin = 1, randomMax = 20;
        static void Main(string[] args)
        {
            while (status)
            {
                Menu();
            }
            
        }
        static void Menu()
        {
            Console.WriteLine("Создать: ");
            Console.WriteLine(" 1.Линию \n 2.Круг \n 3.Окружность \n " +
                "4.Кольцо \n 5.Прямоугольник \n 6.Вывести все фигуры на экран " +
                "\n 7.Выход \n");
            switch (Console.ReadLine())
            {
                case "1": list.Add(new Line(TakeRandomNum(), TakeRandomNum(), TakeRandomNum(), TakeRandomNum()));break;
                case "2":list.Add(new Round(TakeRandomNum(), TakeRandomNum(), TakeRandomNum(), TakeRandomNum()));break;
                case "3": list.Add(new Circle(TakeRandomNum(), TakeRandomNum(), TakeRandomNum(), TakeRandomNum())); break;
                case "4":list.Add(new Ring(TakeRandomNum(), TakeRandomNum(), TakeRandomNum(), TakeRandomNum())); break;
                case "5": list.Add(new Rectangle(TakeRandomNum(), TakeRandomNum(), TakeRandomNum(), TakeRandomNum())); break;
                case "6":if(list.Count==0)
                    {
                        Console.WriteLine("Список элементов пуст");
                    }
                else
                    {
                        foreach (Figure f in list) { f.Print(); };
                    }
                    break;
                    
                case "7": status = false; break;
                default: Console.WriteLine("Вы ввели неверное значение"); break;
            }
        }
        static int TakeRandomNum()
        {
            return r.Next(randomMin, randomMax);
        }
    }
}
