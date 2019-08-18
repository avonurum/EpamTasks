using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Entities;

namespace Task6.DAL
{
    public class MemoryStorage :IStorable
    {
        private static List<User> list = new List<User>();

        public bool DeleteUser(uint userIndex)
        {
            if(userIndex<=list.Count&&userIndex>0)
                {
                list.RemoveAt((int)userIndex);
                return true;
                }
            else return false;
        }
        public void AddUser(User user)
        {
           if(user!=null)
           {
                list.Add(user);
            }
           else throw new ArgumentNullException();
        }
        public void ShowUsers()
        {
            int num = 1;
            foreach (User elem in list)
            {
                    Console.WriteLine(num+".");
                    Console.WriteLine(elem.Id);
                    Console.WriteLine(elem.Name);
                    Console.WriteLine(elem.DateOfBirth);
                    Console.WriteLine(elem.Age);
                    num++;
            }
        }
     }
}
