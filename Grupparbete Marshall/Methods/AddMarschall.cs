using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;

namespace Grupparbete_Marshall.Methods
{
    class AddMarschall
        //marshall id
        //Brinntid ca
        //tid reg
        //anv som reg
        //när slockna
    {
       public static void AddMarshalls()
       {
            
            double burnTime = 0;
            int streetNumber = 0;
            int postalCode = 0;


            //Classes.Marschall marschall = new Classes.Marschall();

            //marshall id saknas

            Console.Write("Ange marshallens märke: ");
            string brand = Console.ReadLine();

            Console.Write("Ange gatuadressen där marshallen är lokaliserad: "); //gata
            string streetName = Console.ReadLine();

            
            Console.Write("Ange gatunummret där marshallen är lokaliserad: "); //gatnr
            try
            {
                streetNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            Console.Write("Ange regionen där marshallen är lokaliserad: "); //region
            string region = Console.ReadLine();

            Console.Write("Ange postkoden där marshallen är lokaliserad: "); //postkod int
            try
            {
                postalCode = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            
            Console.Write("Ange marshallens brinntid i minuter: ");
            try
            {
                burnTime = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            

            Console.Write("Marshallen registerades klockan {0}", DateTime.Now); //tid för reg, datetime, osäker om de är rätt
            //Console.Write(DateTime.Now);
            
            Console.Write("Marshallen förväntas slockna klockan "); //datetime slockna

            Console.Write("Användaren som registrerade marshallen"); //anv reggade

            //Marschall marschall = new Marschall(user, brand, streetName, streetNumber, region, postalCode, burnTime);

        }
    }
}

