using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Menus
{
    class MarschallMenu
    {
        
        static void Run(List<Marschall> all)
        {

            Console.WriteLine("Tryck '1' f�r att se aktiva marschaller");
            Console.WriteLine("Tryck '2' f�r att se alla marschaller");
            int select = 0;
            int.TryParse(Console.ReadLine(), out select) == 1
            if (select == 1)
            {
                List<Marschall> active =
                from x in all
                where DateTime.Compare(x.Burnout, DateTime.Now) > 0
                select x;
                
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