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
        private const string PathForLog = @"L:\test";
        public FileSystemWatcher fileWatcher;
        private static DirectoryInfo dirInfo;
        private string dateTimeOfChanges;

        public Surveillance(string catalogPath)
        {
            CatalogPath = catalogPath;
            Thread.Sleep(1500);
            FileInfo temp = new FileInfo(PathForLog);
            if (temp.IsReadOnly)
                temp.IsReadOnly = false;
            Subscribe();
        }

        private void Subscribe()
        {
                dirInfo = new DirectoryInfo(CatalogPath);
                fileWatcher = new FileSystemWatcher(dirInfo.FullName);

                fileWatcher.Changed += FileChanged;
                fileWatcher.Created += FileChanged;
                fileWatcher.Deleted += FileChanged;
                fileWatcher.Renamed += FileChanged;


                fileWatcher.EnableRaisingEvents = true;
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


        private static void FileChanged(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
           
            DirectoryInfo tempDir = new DirectoryInfo(PathForLog);
            tempDir.N


            Console.WriteLine("Changed");
        }




    }
}
