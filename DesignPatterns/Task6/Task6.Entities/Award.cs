using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Entities
{
    public class Award
    {
        public Guid Id { get; private set; }
        public string Title { get => title;
            private set
            {
                if(!value.Equals(""))
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("Title cannot be empty");
                }
            }
                }

        private string title;
        public Award(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
        }
    }
}
