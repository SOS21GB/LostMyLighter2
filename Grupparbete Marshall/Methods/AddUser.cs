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
            Console.Clear();
            Console.Write("Ange ditt namn: ");
            string name = Console.ReadLine();

            Console.Clear();
            Console.Write("Ange din ålder: ");

            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }
            Console.Clear();
            Console.Write("Ange din Gatuaderss: ");
            string streetAddress = Console.ReadLine();

            Console.Clear();
            Console.Write("Ange ditt Postnummer: ");
            try
            {
                postNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            User user = new User(name, age, streetAddress, postNumber);
            LoginUser.currentUser = user;
            Menus.MenuAtLogin.LoginMenu();
            Console.ReadLine();
        }



    }
}
