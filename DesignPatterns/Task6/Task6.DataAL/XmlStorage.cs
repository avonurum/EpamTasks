﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task6.DataAL
{
    public class XmlStorage
    {
       static public XmlDocument doc = new XmlDocument();

        public XmlStorage()
        {
            doc.Load("Department.xml");
        }

        public void AddUser()
        {


        }
        public void DeleteUser()
        {

            XmlElement Root = doc.DocumentElement;
            int size = Root.ChildNodes.Count;
            bool check = true;
            int num;
            while (check)
            {
                Console.WriteLine("Write down an id of user to delete him:");

                try
                {
                    num = int.Parse(Console.ReadLine()) - 1;
                    if (num < size && num >= 0)
                    {
                        // Root.RemoveChild(Root.ChildNodes[num]);
                        check = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Value is wrong.Please, try again");
                }

            }
            //   doc.Save("Department.xml");

        }
        public void ShowUsers()
        {


        }
    }
}