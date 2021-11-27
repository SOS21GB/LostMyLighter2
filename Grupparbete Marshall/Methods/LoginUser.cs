using Grupparbete_Marshall.Classes;
using Grupparbete_Marshall.Menus;
using System;

namespace Grupparbete_Marshall.Methods
{
    internal class LoginUser
    {
        public static User currentUser = new User();

        public static void UserLogin()
        {
            bool isInvalidInput = false;
            int id = 0;
            do
            {
                Console.WriteLine("Please enter your user ID: ");
                try
                {
                    id = int.Parse(Console.ReadLine());
                    isInvalidInput = false;
                    break;
                }

                catch
                {
                    Console.WriteLine("Invalid input, try again...");
                    isInvalidInput = true;
                }                
                
            } while (isInvalidInput);

            currentUser = User.GetUserById(id);

            if (currentUser == null)
            {
                UserLogin();
            }
            else
            {
                Console.WriteLine("Press any key to clear console and continue to the login screen...");
                Console.ReadKey();
                Console.Clear();
                MenuAtLogin.LoginMenu();
            }
        }
    }
}