using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Entities
{
    public interface IStorable
    {
        void AddUser(User user);
        bool DeleteUser(uint userIndex);
        void ShowUsers();
    }
}
