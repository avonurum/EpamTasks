using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop25
{
    enum UserParams
    {
        Фамилия=0,
        Имя=1,
        Отчество=2,
        Возраст=3,
        Дата_рождения=4,
        Должность=5,
        Стаж_работы=6
    }
    class Program
    {
        static bool status = true;
        static void Main(string[] args)
        {
            Employee emp = new Employee("Иванов", "Иван", "Петрович", "29.04.1985","teacher",10);
            while (status == true)
            {
                Menu(ref emp);
            }
        }

        static void Menu(ref Employee emp)
        {
            Console.WriteLine("Выберите: ");
            Console.WriteLine(" 1.Вывести фамилию \n 2.Изменить фамилию \n 3.Вывести имя \n " +
                "4.Изменить имя \n 5.Вывести отчество \n 6.Изменить отчество " +
                "\n 7.Вывести дату рождения \n 8.Вывести возраст \n 9.Вывести должность \n 10.Изменить должность \n 11.Вывести стаж работы" +
                "\n 12.Изменить стаж работы \n 13.Выход");
            switch (Console.ReadLine())
            {
                case "1": Console.WriteLine(emp.Surname); break;
                case "2": emp.Surname = Console.ReadLine(); break;
                case "3": Console.WriteLine(emp.Name); break;
                case "4": emp.Name = Console.ReadLine(); break;
                case "5": Console.WriteLine(emp.MiddleName); break;
                case "6": emp.MiddleName = Console.ReadLine(); break;
                case "7": Console.WriteLine(emp.DateOfBirth.Date.ToShortDateString()); break;
                case "8": Console.WriteLine(emp.Age); break;
                case "9": Console.WriteLine(emp.Position); break;
                case "10": emp.Position=AddInformation(UserParams.Должность); break;
                case "11": Console.WriteLine(emp.WorkExperience); break;
                case "12": emp.WorkExperience=AddNum(UserParams.Стаж_работы); break;
                case "13": status = false; break;
                default: Console.WriteLine("Вы ввели неверное значение"); break;
            }
        }

        static string AddInformation(UserParams param)//добавление строковых данных
        {
            Console.Write(param + ":");
            return Console.ReadLine();
        }
        static int AddNum(UserParams p)
        {
            Console.WriteLine(p + ": ");
            string temp = Console.ReadLine();
            try
            {
                return int.Parse(temp);
            }
            catch
            {
                Console.WriteLine("Вы ввели не число. Повторите ввод");
                return AddNum(p);
            }
        }
    }
    }
