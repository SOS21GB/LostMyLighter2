using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;
using Grupparbete_Marshall.Methods;

namespace Grupparbete_Marshall.Menus
{
    class MenuAtLogin
    {

        public static void LoginMenu()
        {


            int option = 0;

            do
            {
                bool isInvalidInput = false;
                do
                {
                    Console.WriteLine(@"Main menu

1. Find active marschalls near by
2. List all active marschalls
3. Add new marschall
4. Add existing marschall
5. Change user settings

6. Filter active marschall
7. Change user profile
8. Register lost lighter
9. Show profile
0. Exit program");

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                        isInvalidInput = false;
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("Invalid input, try again...");
                        isInvalidInput = true;
                    }


                } while (isInvalidInput);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Find active marschalls near by");
                        break;

                    case 2:
                        Marschall.PrintActiveMarschall();
                        break;

                    case 3:
                        AddMarschall.AddMarschalls();
                        break;

                    case 4:
                        Console.WriteLine("Add existing marschall");
                        break;

                    case 5:
                        Console.WriteLine("Change user settings");
                        break;

                    case 6:
                        Console.WriteLine("Filter active marschall");
                        break;

                    case 7:
                        User.EditUserMethod(LoginUser.currentUser);
                        break;

                    case 8:
                        User.AddLostLighter(LoginUser.currentUser);
                        break;

                    case 9:
                        User.PrintUser(LoginUser.currentUser);
                        break;

                    case 10:
                        User.LighterHighscore();
                        break;
                    case 0:
                        Console.WriteLine("Exit program!");
                        break;

                    default:
                        Console.WriteLine("Invalid input, try again!");
                        break;
                }


            } while (option != 0);
        }
    }
}

