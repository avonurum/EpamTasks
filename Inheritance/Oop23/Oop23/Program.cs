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
    class Program
    {
        static void Main(string[] args)
        {
            string s="g";
            s.ToString();
            User u = new User();
            u.DateOfBirth = DateTime.Parse("10.01.1995"); 
            Console.WriteLine((DateTime.Now.Year-u.DateOfBirth.Year));
            Console.ReadKey();
        }
    }
}
