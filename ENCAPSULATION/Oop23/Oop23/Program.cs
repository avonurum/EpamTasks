using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop23
{
    /*---Задача 2.3---
     Написать класс User, описывающий человека (Фамилия, Имя, Отчество, Дата рождения, Возраст). 
     Написать программу, демонстрирующую использование этого класса.*/
    

    enum UserParams
    {
        Фамилия,
        Имя,
        Отчество,
        Возраст,
        Дата_рождения,
    }
    class Program
    {
        static bool status = true;
        static void Main(string[] args)
        {
            User user = new User("Иванов","Иван","Петрович","29.04.1995");
            while (status == true)
            {
                Menu(ref user);
            }
        }

        static void Menu(ref User user)
        {
                Console.WriteLine("Выберите: ");
                Console.WriteLine(" 1.Вывести фамилию \n 2.Изменить фамилию \n 3.Вывести имя \n " +
                    "4.Изменить имя \n 5.Вывести отчество \n 6.Изменить отчество " +
                    "\n 7.Вывести дату рождения \n 8.Вывести возраст \n 9.Выход \n");
                switch (Console.ReadLine())
                {
                    case "1": Console.WriteLine(user.Surname); break;
                    case "2": user.Surname = Console.ReadLine(); break;
                    case "3": Console.WriteLine(user.Name); break;
                    case "4": user.Name = Console.ReadLine(); break;
                    case "5": Console.WriteLine(user.MiddleName); break;
                    case "6": user.MiddleName = Console.ReadLine(); break;
                    case "7": Console.WriteLine(user.DateOfBirth.Date.ToShortDateString()); break;
                    case "8": Console.WriteLine(user.Age); break;
                    case "9": status = false; break;
                    default: Console.WriteLine("Вы ввели неверное значение"); break;
                }
        }

        static string AddInformation(UserParams param)//добавление строковых данных
        {
            Console.Write(param + ":");
            return Console.ReadLine();
        }
    }
}
