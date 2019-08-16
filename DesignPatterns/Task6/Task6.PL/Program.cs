using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task6.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            XmlDocument dc = new XmlDocument();
            dc.Load("dcllsjc");
        }

        static void Menu()
        {
            Console.WriteLine("Choose:");
            Console.WriteLine("1. Create user\n" +
                "2. Delete user\n" +
                "3.Show users\n" +
                "4.Exit");
            if(uint.TryParse(Console.ReadLine(), out uint secectedOption)
                && secectedOption>0
                && secectedOption<4)
            {
                switch(secectedOption)
                {
                    case 1:
                        //method 
                        Console.WriteLine("Создание");
                        Menu();
                        break;
                    case 2:
                        //method
                        Console.WriteLine("Удаление");
                        Menu();
                        break;
                    case 3:
                        //method 
                        Console.WriteLine("Вывод всех");
                        Menu();
                        break;
                    case 4:
                        Console.WriteLine("Выход");
                        return;
                }
            }
        }
        
    }
}
