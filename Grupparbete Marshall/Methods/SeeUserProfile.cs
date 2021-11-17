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
            Console.WriteLine("ID:{0}", user.Id);
            Console.WriteLine("Name:{0}", user.Name);
            Console.WriteLine("Age:{0}", user.Age);
            Console.WriteLine("Street Adress:{0}", user.StreetAddress);
            Console.WriteLine("Post Number:{0}", user.PostNumber);
            Console.WriteLine("Number Of Seach:{0}", user.NumberOfSearch);
            Console.WriteLine("Found Marchall:{0}", user.FoundMarschall);
            Console.WriteLine("Lost Lighters:{0}", user.LostLighters); 
                
             
        }
        
        




    }


}
