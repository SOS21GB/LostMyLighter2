using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;

namespace Grupparbete_Marshall.Lists
{
    class UserList
    {
        static private int _userId = 5;
        static public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        
        public static List<Classes.User> userList = new List<Classes.User>();
        public static User GetUser() 
        {
            return userList[_userId - 1];
        } 
        public static void InitializeUserList()
        {
            new Classes.User("Anders Andersson", 30, "Exempeladress 1", 40010, 0, 0, 0 );
            new Classes.User("Anders Johansson", 30, "Exempeladress 2", 40010, 0, 0, 0);
            new Classes.User("Anders Göransson", 30, "Exempeladress 3", 40010, 0, 0, 0);
            new Classes.User("Anders Nilsson", 30, "Exempeladress 4", 40010, 0, 0, 0);
            new Classes.User("Anders Olsson", 30, "Exempeladress 5", 40010, 0, 0, 0);
        }                
    }
}
