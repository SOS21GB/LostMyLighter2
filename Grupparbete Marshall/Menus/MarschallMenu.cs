using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Menus
{
    class MarschallMenu
    {
        List<Marschall> all;
        List<Marschall> active;

        static void Main(string[] args)
        {

            Console.WriteLine("Tryck '1' för att se aktiva marschaller");
            Console.WriteLine("Tryck '2' för att se alla marschaller");
            int select = 0;
            int.TryParse(Console.ReadLine(), out select) == 1
            if (select == 1)
            {
                foreach (Marschall m in active)
                {
                    Console.WriteLine(m.Print());
                }
            }
            else
            {
                foreach (Marschall m in all)
                {
                    Console.WriteLine(m.Print());
                }
            }

        }

    }
}