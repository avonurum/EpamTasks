using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Entities
{
    public class User
    {
        private string name;
        private string dateOfBirth;
        private const int minAge = 7;
        public User(string name, DateTime dateOfBirth)
        {
            Id = Guid.NewGuid();
            Name = name;
            DateOfBirth = SetDateOfBirth(dateOfBirth);
            Age = DateTime.Now.Year - dateOfBirth.Year;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value != null && !value.Equals("") && Char.IsUpper(value[0]))
                {
                    name = value;
                }
                else throw new ArgumentException("Name cannot be null or empty and the first letter of name must be uppercase");
            }
        }
        public string SetDateOfBirth(DateTime date)
        {
                if (date.Year < DateTime.Now.Year - minAge)
                {
                return date.ToShortDateString();
                }
                else throw new ArgumentException($"Date of Birth cannot be earlier than {minAge} years ago");
            
        }
        public int Age { get; private set; }
        public Guid Id { get; private set; }
        public string DateOfBirth { get => dateOfBirth;private set => dateOfBirth = value; }
    }
}
