using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Task5
{
    class Surveillance
    {
        private static string catalogPath;
        private static bool isAllowedToWrite;
        private const string PathForLog = @"C:\temp.xml";
        private static XmlDocument document;
        public FileSystemWatcher fileWatcher;
        private DirectoryInfo dirInfo;

        public Surveillance(string catalogPath)
        {
            CatalogPath = catalogPath;
            Thread.Sleep(1500);
            OnObserve();
            if (isAllowedToWrite)
            {
                try
                {
                    var xmlWriter = new XmlTextWriter(PathForLog, Encoding.UTF8)
                    {
                        Formatting = Formatting.Indented,
                        Indentation = 4
                    };
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Observe");
                    xmlWriter.WriteEndElement();
                    xmlWriter.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            FileInfo temp = new FileInfo(PathForLog);
            if (temp.IsReadOnly)
                temp.IsReadOnly = false;

            document = new XmlDocument();
            document.Load(PathForLog);
            Subscribe();
        }

        private void Subscribe()
        {
            if (isAllowedToWrite)//если режим наблюдения
            {
                dirInfo = new DirectoryInfo(CatalogPath);
                fileWatcher = new FileSystemWatcher(dirInfo.FullName);
            }
            else //если режим отката
            {
                Console.Clear();
            }
        }

        private void returnChanges()
        {

        }

        public static string CatalogPath
        {
            get => catalogPath;
            set
            {
                if (!Directory.Exists(value))//проверка на наличие каталога
                {
                    throw new DirectoryNotFoundException(value);
                }
                else
                {
                    catalogPath = value;
                }
            }
        }

        private void OnObserve()
        {
            bool ModeIsChosen = false;
            while (!ModeIsChosen)
            {
                Console.Clear();
                Console.WriteLine("Наблюдать или перейти в режим отката ? y/n");
                var answer = Console.ReadKey();
                if (answer.Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    isAllowedToWrite = true;
                    Console.WriteLine("Режим наблюдения");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                }

                else if (answer.Key == ConsoleKey.N)
                {
                    Console.WriteLine();
                    isAllowedToWrite = false;
                    Console.WriteLine("Режим отката");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                }
                else
                {
                    throw new ArgumentException("");
                }
            }
        }
    }
}
