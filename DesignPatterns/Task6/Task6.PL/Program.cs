using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Task6.BLL;
using Task6.Entities;


namespace Task6.PL
{
    class Program
    {
        static UserManager userManager=new UserManager();
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Choose:");
            Console.WriteLine("1. Create user\n" +
                "2. Delete user\n" +
                "3. Show users\n" +
                "4. Exit");
            if (uint.TryParse(Console.ReadLine(), out uint secectedOption)
                && secectedOption > 0
                && secectedOption < 4)
            {
                switch (secectedOption)
                {
                    case 1:
                        if (CreateUser()) Console.WriteLine("User was created");
                        else Console.WriteLine("User was not created");
                        Menu();
                        break;
                    case 2:
                        if (DeleteUserByNumber()) Console.WriteLine("User was deleted");
                        else Console.WriteLine("User was not deleted");
                        Menu();
                        break;
                    case 3:
                        ShowUsers();
                        Menu();
                        break;
                    case 4:
                        return;
                }
            }
        }

        static bool CreateUser()
        {
            Console.WriteLine("Name:");
            string tempName = Console.ReadLine();
            DateTime tempDateOfB = DateTime.Now;
            Console.WriteLine("DateOfBirth:");
            if (DateTime.TryParse(Console.ReadLine().ToString(), out DateTime result))
            {
                tempDateOfB = result;
            }
            try
            {
            User ty = new User(tempName, tempDateOfB);
            userManager.AddUser(ty);
                return true;
            }
            catch
            {
                return false;
            }

        }
        static bool DeleteUserByNumber()
        {
            Console.WriteLine("Write down inder number of user to delete him");
            uint selectedChoise = 0;
            if (uint.TryParse(Console.ReadLine(), out uint result))
            {
                selectedChoise = result;
            }
            return userManager.DeleteUser(result);
        }
        static void ShowUsers()
        {
            userManager.ShowUsers();
        }
    }
}
