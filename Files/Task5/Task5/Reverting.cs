using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task5
{
    class Reverting
    {

        private string dateTimeOfChanges;
        private const string PathForLog = @"L:\test";



        private void Subscribe()
        {
            Console.Clear();
            Console.WriteLine("Введите дату и/или время на которую \nнеобходимо сделать откат, вида \"{0}\" :", DateTime.Now.ToString());
            dateTimeOfChanges = Console.ReadLine();
            try
            {
                DateTime.Parse(dateTimeOfChanges).ToString();
                Thread.Sleep(1500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1500);
                Subscribe();
            }
        }
    }
}
