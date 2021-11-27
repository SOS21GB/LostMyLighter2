using Grupparbete_Marshall.Classes;
using Grupparbete_Marshall.Methods;
using System;

namespace Grupparbete_Marshall.Menus
{
    internal class MenuAtLogin
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
0. Add new marschall
1. List all registered marschalls
2. List all active marschalls
3. Filter marschalls by postalcode
4. List all your marschalls
5. Show profile
6. Change user profile

7. Register a lost lighter
8. Highscore amount of lost lighters
9. Highscore amount of found marschalls
10. Log out");

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
                    case 0:
                        AddMarschall.AddMarschalls();
                        break;

                    case 1:
                        Marschall.PrintAllMarschalls();
                        break;

                    case 2:
                        Marschall.PrintActiveMarschall();
                        break;

                    case 3:
                        FilterActiveMarschall.FilterMarschall();
                        break;

                    case 4:
                        Marschall.PrintUserMarschall(LoginUser.currentUser);
                        break;
                    case 5:
                        User.PrintUser(LoginUser.currentUser);
                        break;

                    case 6:
                        User.EditUserMethod(LoginUser.currentUser);
                        break;

                    case 7:
                        User.AddLostLighter(LoginUser.currentUser);
                        break;

                    case 8:
                        User.LighterHighScore();
                        break;

                    case 9:
                        User.FoundMarschallScore();
                        break;

                    case 10:
                        Startmenu.RunStartMenu();
                        break;

                    default:
                        Console.WriteLine("Invalid input, try again!");
                        break;
                }
            } while (option != 0);
        }
    }
}