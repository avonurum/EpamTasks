using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop25
{
    class Employee:User
    {
        private string position;
        private int workExperience;

        public Employee(string surname, string name, string middleName, string dateOfBirth, string position, int workExp) : base(surname, name, middleName, dateOfBirth)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            DateOfBirth = DateOfBirth = DateTime.Parse(dateOfBirth);
            Position = position;
            if(CheckWorkExp(workExp))
            {
                WorkExperience = workExp;
            }
            

        }

        public string Position { get => position; set => position = value; }
        public int WorkExperience { get => workExperience; set => workExperience = value; }

        public bool CheckWorkExp(int workExp)
        {
            if(Age-workExp>14)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Стаж работы не может быть больше чем возраст");
            }

        }
    }
}
