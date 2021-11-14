using Grupparbete_Marshall.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Lists;


namespace Grupparbete_Marshall.Methods
{
    class SeeUserProfile
    {
        public static User GetUser(int id)
        {
            User foundUser = UserList.userList.Find(user => user.Id == id);
            return foundUser;
        }
        public static void PrintUser(int id)
        {
            User user = GetUser(id);
            Console.WriteLine(user.Id);
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Age);
                
             
        }
        
        




    }


}
