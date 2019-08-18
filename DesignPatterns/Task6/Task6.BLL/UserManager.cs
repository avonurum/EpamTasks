using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Task6.DAL;
using Task6.Entities;
using Task6.Configuration;

namespace Task6.BLL
{
    public class UserManager
    {
         private IStorable data;

        public UserManager()
        {
           int i = Config.GetInformation();
            if (i == 0)
            {
                data = new XmlStorage();
            }
            else if (i == 1)
            {
                data = new MemoryStorage();
            }
            else throw new ArgumentException("File contains wrong data");
        }

        public  IStorable Data { get => data;private set => data = value; }

        public void AddUser(User user)
        {
            data.AddUser(user);
        }
        public bool DeleteUser(uint userIndex)
        {
            return data.DeleteUser(userIndex);
        }
        public void ShowUsers()
        {
            data.ShowUsers();
        }
    }
}
