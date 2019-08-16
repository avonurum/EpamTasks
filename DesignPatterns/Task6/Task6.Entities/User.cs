using System;

namespace Task6.Entities
{
    public class User
    {
        private Guid id;
        private string name;
        private DateTime dateOfBirth;
        private int age;
        private const int minAge = 7;
        public User(string name, DateTime dateOfBirth)
        {
            Id = new Guid();
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = DateTime.Now.Year - dateOfBirth.Year;
        }

        public string Name { get; private set; }
        public DateTime DateOfBirth {
            get
            {
               return dateOfBirth;
            }
            private set
            {
                if (dateOfBirth.Year > DateTime.Now.Year + minAge)
                {
                    dateOfBirth = value;
                }
                else throw new ArgumentException($"Date of Birth cannot be earlier than {minAge} years ago");
            }
            }
        public int Age { get; private set; }
        public Guid Id { get; private set; }
    }
}
