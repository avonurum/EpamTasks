using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Entities
{
    public static class AwardHolder
    {
        private static HashSet<Award> awardsAreHold;

        static AwardHolder()
        {
            awardsAreHold = new HashSet<Award>();
        }

        public static void AddDependency(Award award)
        {
                awardsAreHold.Add(award);
        }
        public static bool CheckKey(Award award)
        {
           return awardsAreHold.Contains(award);
        }
    }
}
