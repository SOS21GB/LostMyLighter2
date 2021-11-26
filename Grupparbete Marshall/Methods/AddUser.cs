using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;


namespace Grupparbete_Marshall.Methods
{
    class AddUser
    {
        public static void AddUsers()
        {

            int age = 0;
            int postNumber = 0;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            Console.Write("Enter your age: ");

            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input, try again ..");
            }

            Console.Write("Enter your Street Address: ");
            string streetAddress = Console.ReadLine();

            Console.Write("Enter your Postcode: ");
            try
            {
                postNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input, try again..");
            }

            User user = new User(name, age, streetAddress, postNumber);
            LoginUser.currentUser = user;

            Console.WriteLine("You got ID: {0}", user.ID);
            Console.WriteLine("Remember it, you will use it to log in... ");


            Console.WriteLine("Press any key to clear console and return to main menu...");
            Console.ReadKey();
            Console.Clear();
            Menus.MenuAtLogin.LoginMenu();

        }



    }
}
