using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Methods
{
    class FilterActiveMarschall
    {
        public static void FilterMarschall()
        {

            int filterPostCode = 0;
            int activeMarschalls = 0;


            do
            {
                Console.WriteLine("Enter postCode: ");
                var postCode = int.Parse(Console.ReadLine());

            }
            while (int.TryParse(Console.ReadLine(), out filterPostCode));


            foreach (Marschall m in avtiveMarschalls.Where(x => x.PostCode == filterPostCode))
            {
                Console.WriteLine($"All active Marschalls in Postcode: {activeMarschalls}");
                Console.ReadLine();


            }

            Console.WriteLine("\n Press any key to return to Main menu");
            Console.ReadKey();
        }
    }
}

