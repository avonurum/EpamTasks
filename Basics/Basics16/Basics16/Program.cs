using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics16
{
    /*   ---Задание 1.6---
    *   Для форматирования текста надписи можно использовать различные : полужирное, курсивное и подчёркнутое, а также их сочетания.
    *   Предложите способ хранения информации о форматировании текста надписи и напишите программу, которая позволяет устанавливать и 
    *   изменять начертание:*/
    enum TypesOfStyle
    {
        none,
        bold,
        italic,
        underline,
        empty
    }
    class Program
    {
        static bool isContinue = true;
        static void Main(string[] args)
        {
            TypesOfStyle[] f = new TypesOfStyle[4] { TypesOfStyle.none, TypesOfStyle.empty, TypesOfStyle.empty, TypesOfStyle.empty }; //массив

            while (isContinue)
            {
                Menu(f);
                ShowState(f);
            }
        }

        static void Menu(TypesOfStyle[] state) //меню
        {
            Console.WriteLine($"Введите:\n 1.{TypesOfStyle.bold.ToString()}\n 2.{TypesOfStyle.italic.ToString()} \n 3." +
                                $"{TypesOfStyle.underline.ToString()}+\n Exit");
            switch (Console.ReadLine())
            {
                case "1": ChangeState(TypesOfStyle.bold, state); break;
                case "2": ChangeState(TypesOfStyle.italic, state); break;
                case "3": ChangeState(TypesOfStyle.underline, state); break;
                case "Exit": isContinue = false; break;
                default: Console.WriteLine("Введено неверное значение."); Menu(state); break;
            }
        }

        static void ChangeState(TypesOfStyle c, TypesOfStyle[] state)//метод для изменения состояния
        {
            if (state[(int)c] == TypesOfStyle.empty)//если выбранный стиль еще не был задействован, то выбираем его
            {
                state[(int)c] = c;
            }
            else //иначе убираем данный стиль
            {
                state[(int)c] = TypesOfStyle.empty;
            }

            int empty = 0;//счетчик

            for (int i = 1; i < state.Length; i++)
            {
                //если стиль равен empty увеличиваем счетчик
                if (state[i] == TypesOfStyle.empty)
                {
                    empty++;
                }
            }
            //если все 3 стиля(bold,italic,underline)пусты нам нужно оповестить пользователя о том, что не применен ни один стиль
            if (empty == 3)
            {
                state[0] = TypesOfStyle.none;
            }
            else
            {
                state[0] = TypesOfStyle.empty;
            }
        }

        static void ShowState(TypesOfStyle[] state)//вывод стилей
        {
            Console.WriteLine("Параметры надписи:");
            if (state[0] == TypesOfStyle.none)
            {
                Console.Write(state[0]);
            }
            else
            {
                for (int i = 0; i < state.Length; i++)
                {
                    if (state[i] != TypesOfStyle.empty) Console.Write(state[i].ToString() + " ");
                }
            }
            Console.Write(Environment.NewLine);
        }
    }
}
