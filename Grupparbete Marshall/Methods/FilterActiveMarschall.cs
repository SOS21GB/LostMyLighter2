using Grupparbete_Marshall.Classes;
using System;
using System.Linq;

namespace Grupparbete_Marshall.Methods
{
    internal class FilterActiveMarschall
    {
        public static void FilterMarschall()
        {
            int filterPostCode = 0;

            Console.WriteLine("Enter postCode: ");
            filterPostCode = int.Parse(Console.ReadLine());

            var matchingMarschalls = Classes.Marschall.marschallList.Where(marschall => marschall.PostalCode == filterPostCode);

            Console.Clear();

            foreach (Marschall marschall in matchingMarschalls)
            {
                Marschall.PrintMarschall(marschall);
            }
            User.AddSearch(LoginUser.currentUser);
            Console.WriteLine("\n Press any key to return to Main menu");
            Console.ReadKey();
            Console.Clear();
            Menus.MenuAtLogin.LoginMenu();
        }
    }
}