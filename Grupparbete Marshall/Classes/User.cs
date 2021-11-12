using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Classes
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string StreetAddress { get; set; }
        public int PostNumber { get; set; }
        public int NumberOfSearch { get; set; }
        public int FoundMarschall { get; set; }
        public int LostLighters { get; set; }

        public User()
        {

        }

        public User(int i, string n, int a, string s, int p, int ns, int f, int l)
        {
            this.Id = i;
            this.Name = n;
            this.Age = a;
            this.StreetAddress = s;
            this.PostNumber = p;
            this.NumberOfSearch = ns;
            this.FoundMarschall = f;
            this.LostLighters = l;
        }

    }
}
