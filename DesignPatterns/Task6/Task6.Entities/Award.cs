using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Entities
{
    class Award
    {
        public Guid Id { get; private set; }
        public string Title { get => title;private set => title = value; }

        private string title;
    }
}
