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

        private int _id;
        private string _name;
        private int _age;
        private string _streetAddress;
        private int _postNumber;
        private int _numberOfSearch = 0;
        private int _foundMarschall = 0;
        private int _lostLighters = 0;

        private static List<User> userList = new List<User>();


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

        public User(int i, string n, int a, string s, int p)
        {
            this._id = i;
            this._name = n;
            this._age = a;
            this._streetAddress = s;
            this._postNumber = p;
            userList.Add(this);
        }


        public static void InitializeUserList()
        {
            new User(1, "Anders Andersson", 30, "Exempeladress 1", 40010);
            new User(2, "Anders Johansson", 30, "Exempeladress 2", 40010);
            new User(3, "Anders Göransson", 30, "Exempeladress 3", 40010);
            new User(4, "Anders Nilsson", 30, "Exempeladress 4", 40010);
            new User(5, "Anders Olsson", 30, "Exempeladress 5", 40010);

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
