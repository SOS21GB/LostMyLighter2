using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;

namespace Grupparbete_Marshall.Methods
{
    class AddMarschall
    {
        public static void AddMarschalls()
        {
            double burnTime = 0;
            int streetNumber = 0;
            int postalCode = 0;

            Console.Write("Ange marschallens märke: ");
            string brand = Console.ReadLine();

            Console.Write("Ange gatuadressen där marschallen är lokaliserad: ");
            string streetName = Console.ReadLine();

            Console.Write("Ange gatunummret där marschallen är lokaliserad: ");
            try
            {
                streetNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            Console.Write("Ange postkoden där marschallen är lokaliserad: ");
            try
            {
                postalCode = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            Console.Write("Ange marschallens brinntid i minuter: ");
            try
            {
                burnTime = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            Console.WriteLine("Marschallen registerades klockan {0}", DateTime.Now);

            Console.WriteLine("Marschallen förväntas slockna klockan {0} ", DateTime.Now.AddMinutes(burnTime));

            Marschall marschall = new Marschall(brand, burnTime, LoginUser.currentUser.ID, streetName, streetNumber, postalCode);
            User.AddFoundMarshall(LoginUser.currentUser);

            Console.WriteLine("Press any key to clear console and return to main menu...");
            Console.ReadKey();
            Console.Clear();
            Menus.MenuAtLogin.LoginMenu();
        }
    }
}

