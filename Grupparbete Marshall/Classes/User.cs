using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Grupparbete_Marshall.Lists;


namespace Grupparbete_Marshall.Classes
{
    class User
    {
        //public static User CurrentUser;
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
            Id = UserList.userList.Count + 1;//Tilldelar id utefter vilken plats på listan användaren hamnar i.
            Lists.UserList.userList.Add(this);
        }

        public User(string n, int a, string s, int p, int ns, int f, int l)
        {
            this.Id = UserList.userList.Count + 1;
            this.Name = n;
            this.Age = a;
            this.StreetAddress = s;
            this.PostNumber = p;
            this.NumberOfSearch = ns;
            this.FoundMarschall = f;
            this.LostLighters = l;
            Lists.UserList.userList.Add(this);
        }
        public void DisplayUserInfo() 
        {
            WriteLine($"ID: {Id}");
            WriteLine($"Name: {Name}");
            WriteLine($"Age: {Age}");
            WriteLine($"StreetAddress: {StreetAddress}");
            WriteLine($"PostNumber: {PostNumber}");
            WriteLine($"NumberOfSearch: {NumberOfSearch}");
            WriteLine($"FoundMarschall: {FoundMarschall}");
            WriteLine($"LostLighters: {LostLighters}");

        }
    }   
}
