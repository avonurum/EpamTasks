using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Configuration
{
    public class Config
    {
        static private string pathToFile = @"D:\Program\repos\Task6\TextFile1.txt";

        public static int GetInformation()
        {
            FileStream file1 = new FileStream(pathToFile, FileMode.Open); 
            StreamReader reader = new StreamReader(file1);
            if (int.TryParse(reader.ReadToEnd(), out int result))
            {
                return result;
            }
            else throw new ArgumentException("File contains wrong data");
            
        }
    }
}
