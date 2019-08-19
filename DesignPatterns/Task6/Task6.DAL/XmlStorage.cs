using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using Task6.Entities;

namespace Task6.DAL
{
    public class XmlStorage:IStorable
    {
        private XmlDocument doc;
        private List<string> tags = new List<string> { "USER", "ID", "NAME", "DATEOFBIRTH", "AGE", "AWARDLIST","AWARD","AWARDID","TITLE" };
        private const string pathForStorage = @"D:\Program\repos\Task6\XMLFile1.xml"; 

        public XmlDocument Doc { get => doc; private set => doc = value; }

        public static string PathForStorage => pathForStorage;

        public XmlStorage()
        {
            ValidatingXML.Valid();
            doc = new XmlDocument();
            try
            {
                doc.Load(PathForStorage);
            }
            catch(Exception)
            {
                Console.WriteLine("File was not downloaded");
            }

        }

        public void AddUser(User user)
        {
            XmlElement Root = Doc.DocumentElement;
            XmlElement userElem = Doc.CreateElement(tags[0]);


            XmlElement userId = Doc.CreateElement(tags[1]);
            XmlElement userName = Doc.CreateElement(tags[2]);
            XmlElement userDateOfBirth = Doc.CreateElement(tags[3]);
            XmlElement userAge = Doc.CreateElement(tags[4]);
            XmlText usId = Doc.CreateTextNode(user.Id.ToString());
            XmlText usName = Doc.CreateTextNode(user.Name);
            XmlText usDateOfBirth = Doc.CreateTextNode(user.DateOfBirth.ToString());
            XmlText usAge = Doc.CreateTextNode(user.Age.ToString());

            userId.AppendChild(usId);
            userName.AppendChild(usName);
            userDateOfBirth.AppendChild(usDateOfBirth);
            userAge.AppendChild(usAge);
            userElem.AppendChild(userId);
            userElem.AppendChild(userName);
            userElem.AppendChild(userDateOfBirth);
            userElem.AppendChild(userAge);
            Root.AppendChild(userElem);

            Doc.Save(PathForStorage);


        }
        public bool DeleteUser(uint userIndex)
        {

            XmlElement Root = Doc.DocumentElement;
            int size = Root.ChildNodes.Count;
            try
            {
                if (userIndex - 1 < size && userIndex - 1 >= 0)
                {
                    Root.RemoveChild(Root.ChildNodes[(int)userIndex-1]);
                }
                Doc.Save(PathForStorage);
                return true;
            }
            catch
            {
                Console.WriteLine("Value is wrong.");
                return false;
            }
        }
        public void ShowUsers()
        {
            int num = 1;
            foreach (XmlElement user in Doc.GetElementsByTagName(tags[0]))
            {
                Console.WriteLine(num + ".");
                
                for (int i = 0; i < user.ChildNodes.Count; i++)
                {
                    if (user.ChildNodes[i].LocalName.Equals("AWARDLIST"))
                    {
                        foreach (XmlElement award in Doc.GetElementsByTagName("AWARDLIST"))
                        {
                            for (int j=0;j<award.ChildNodes.Count;j++)
                            {
                                foreach(XmlElement aw in award.ChildNodes[j])
                                {
                                    Console.WriteLine("\t"+aw.InnerText);
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(user.ChildNodes[i].InnerText);
                    }
                    
                }
                num++;
                Console.WriteLine();
            }
        }

       public bool AddAwardToUserByNumber(uint userIndex, Award award)
        {
            XmlElement Root = Doc.DocumentElement;
            int size = Root.ChildNodes.Count;
            try
            {
                if (userIndex - 1 < size && userIndex - 1 >= 0)
                {
                    int awardListidnx=-1;
                    XmlNode userElem = Root.ChildNodes[(int)userIndex - 1];
                    for (int i=0;i< userElem.ChildNodes.Count;i++)
                    {
                        if(userElem.ChildNodes[i].LocalName.Equals("AWARDLIST"))
                        {
                            awardListidnx = i;
                            break;
                        }
                    }
                    if(awardListidnx==-1)
                    {
                        XmlElement userListElem = Doc.CreateElement(tags[5]);
                        userElem.AppendChild(userListElem);
                    }
                    XmlElement awardElem = Doc.CreateElement(tags[6]);

                    XmlElement awardIdElem = Doc.CreateElement(tags[7]);
                    XmlText awardIdText = Doc.CreateTextNode(award.Id.ToString());
                    XmlElement awardTitleElem = Doc.CreateElement(tags[8]);
                    XmlText awardTitleText = Doc.CreateTextNode(award.Title);

                    awardIdElem.AppendChild(awardIdText);
                    awardTitleElem.AppendChild(awardTitleText);
                    awardElem.AppendChild(awardIdElem);
                    awardElem.AppendChild(awardTitleElem);
                    userElem.LastChild.AppendChild(awardElem);


                }
                Doc.Save(PathForStorage);
                return true;
            }
            catch
            {
                Console.WriteLine("Value is wrong.");
                return false;
            }
        }
    }

    class ValidatingXML
    {
        public static void Valid()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;
            settings.ValidationEventHandler += new ValidationEventHandler(HandleEvent);
            XmlReader reader = XmlReader.Create(XmlStorage.PathForStorage, settings);
            while (reader.Read()) ;
            reader.Close();

        }

        public static void HandleEvent(object sender, ValidationEventArgs e)
        {
            Console.WriteLine("Error : {0}", e.Message);
        }
    }
}

