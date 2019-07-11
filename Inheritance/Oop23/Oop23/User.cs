using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop23
{
    
    class User
    {
        private static int edge = 10;//минимальный возраст пользователя
        private string surname;
        private string name;
        private string middleName;
        private DateTime dateOfBirth;
        private int age;

        //решила сделать сеттер приватным, следуя логике, что человек с другой датой рождения - это уже другой человек. 
        // про ограничения по возрасту ничего не было сказано, но я решила ввести его на всякий случай) Так как в дальнейшем нам необходимо 
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set
            {
                if (value.Year > (DateTime.Now.Year - edge))
                {
                    throw new ArgumentException("Дата рождения пользователя не может быть позже чем 10 лет назад");
                }
                else dateOfBirth = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                if (CheckName(value)) surname = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (CheckName(value)) name = value;
            }
        }

        public string MiddleName
        {
            get => middleName;
            set
            {
                if (CheckName(value)) middleName = value;
            }
        }

        private bool CheckName(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Значение не введено и ввидены символы-разделители(пробел или т.п.)");
            }
            else if (value[0] != char.ToUpper(value[0]))
            {
                throw new ArgumentException("Первая буква фамилии, имени и отчества должна быть в верхнем регистре");
            }
            else return true;
        }
    }


}
