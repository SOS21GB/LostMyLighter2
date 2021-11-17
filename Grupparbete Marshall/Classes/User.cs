using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Classes
{
    class User
    {
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

        }

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

    }
}
