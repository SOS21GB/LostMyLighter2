using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;
using Grupparbete_Marshall.Lists;

namespace Grupparbete_Marshall.Menus
{
    class MarschallMenu
    {
        

        public static void MarshallMenu()
        {

            Console.WriteLine("Tryck '1' för att se aktiva marschaller");
            Console.WriteLine("Tryck '2' för att se alla marschaller");
            
            if (int.TryParse(Console.ReadLine(), out int select)) 
            {
                if (select == 1)
                {
                    foreach (Marschall m in MarshallList.active)
                    {
                        Console.WriteLine(m.Print());
                    }
                }
                else
                {
                    foreach (Marschall m in MarshallList.all)
                    {
                        Console.WriteLine(m.Print());
                    }
                }
            } 
            

        }

    }
}