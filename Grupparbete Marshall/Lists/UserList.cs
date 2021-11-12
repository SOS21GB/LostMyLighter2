using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Lists
{
    class UserList
    {
        private int _userId = 5;
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        
        public static List<Classes.User> userList = new List<Classes.User>();

        public static void InitializeUserList()
        {
            userList.Add(new Classes.User(1, "Anders Andersson", 30, "Exempeladress 1", 40010, 0, 0, 0 ));
            userList.Add(new Classes.User(2, "Anders Johansson", 30, "Exempeladress 2", 40010, 0, 0, 0));
            userList.Add(new Classes.User(3, "Anders Göransson", 30, "Exempeladress 3", 40010, 0, 0, 0));
            userList.Add(new Classes.User(4, "Anders Nilsson", 30, "Exempeladress 4", 40010, 0, 0, 0));
            userList.Add(new Classes.User(5, "Anders Olsson", 30, "Exempeladress 5", 40010, 0, 0, 0));
        }                
    }
}
