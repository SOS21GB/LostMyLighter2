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

1. Add new marschall
2. List all active marschalls
3. Filter marschalls by postalcode
4. Show profile
5. Change user profile

6. Register a lost lighter
7. Highscore amount of lost lighters
8. Highscore amount of found marschalls
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
                        AddMarschall.AddMarschalls();
                        break;

                    case 2:
                        Marschall.PrintActiveMarschall();
                        break;

                    case 3:
                        FilterActiveMarschall.FilterMarschall();
                        break;

                    case 4:
                        User.PrintUser(LoginUser.currentUser);
                        break;

                    case 5:
                        User.EditUserMethod(LoginUser.currentUser);
                        break;

                    case 6:
                        User.AddLostLighter(LoginUser.currentUser);
                        break;

                    case 7:
                        User.LighterHighScore();
                        break;

                    case 8:
                        User.FoundMarschallScore();
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

