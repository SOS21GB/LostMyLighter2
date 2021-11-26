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
4. Show profile
5. Change user profile

6. Register a lost lighter
7. Highscore amount of lost lighters
8. Highscore amount of found marschalls
9. Log out");

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

                    case 9:
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