using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Grupparbete_Marshall.Classes
{
    class User
    {

        public static List<User> userList = new List<User>();

        public static void InitializeUserList()
        {
            new Classes.User("Anders Andersson", 30, "Exempeladress 1", 40010, 0, 0, 0);
            new Classes.User("Anders Johansson", 30, "Exempeladress 2", 40010, 0, 0, 0);
            new Classes.User("Anders Göransson", 30, "Exempeladress 3", 40010, 0, 0, 0);
            new Classes.User("Anders Nilsson", 30, "Exempeladress 4", 40010, 0, 0, 0);
            new Classes.User("Anders Olsson", 30, "Exempeladress 5", 40010, 0, 0, 0);
        }


        private int _id;
        private string _name;
        private int _age;
        private string _streetAddress;
        private int _postNumber;
        private int _numberOfSearch = 0;
        private int _foundMarschall = 0;
        private int _lostLighters = 0;

        public int ID {
            get { return  _id; }
            set { _id = value; }
        }

        public User()
        {          
        }


        public User(string n, int a, string s, int p, int ns, int f, int l)
        {
            this._id = userList.Count + 1;
            this._name = n;
            this._age = a;
            this._streetAddress = s;
            this._postNumber = p;
            this._numberOfSearch = ns;
            this._foundMarschall = f;
            this._lostLighters = l;
            userList.Add(this);
        }

        public User(string n, int a, string s, int p)
        {
            this._id = userList.Count + 1;
            this._name = n;
            this._age = a;
            this._streetAddress = s;
            this._postNumber = p;
            userList.Add(this);
        }

        public void PrintUser()
        {
            
            Console.WriteLine("ID:{0}", _id);
            Console.WriteLine("Name:{0}", _name);
            Console.WriteLine("Age:{0}", _age);
            Console.WriteLine("Street Adress:{0}", _streetAddress);
            Console.WriteLine("Post Number:{0}", _postNumber);
            Console.WriteLine("Number Of Seach:{0}", _numberOfSearch);
            Console.WriteLine("Found Marchall:{0}", _foundMarschall);
            Console.WriteLine("Lost Lighters:{0}", _lostLighters);

        }
    }
}
