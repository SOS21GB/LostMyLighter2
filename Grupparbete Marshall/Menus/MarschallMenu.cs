using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Menus
{
    class MarschallMenu
    {
        
        static void Run(User me, List<Marschall> all)
        {
            int select = 0;
            do {
                Console.WriteLine("Tryck '1' för att lägga till marschall");
                Console.WriteLine("Tryck '2' för att se aktiva marschaller");
                Console.WriteLine("Tryck '3' för att se alla marschaller");               
            } while (!int.TryParse(Console.ReadLine(), out select));
            switch (select)
            {
                case 1:
                    Console.WriteLine("på vilken gata är marschallen?");
                    String sa = Console.ReadLine();
                    
                    int sb = 0;
                    do {
                        Console.WriteLine("på vilket husnummer är marschallen?");
                    } while (int.TryParse(Console.ReadLine(), out sb))
                    
                    Console.WriteLine("i vilken kommun är marschallen?");
                    String sc = Console.ReadLine();
                   
                    int sd = 0;
                    do { 
                        Console.WriteLine("vilken postnummer har marschallen?");
                    } (int.TryParse(), out sd);

                        
                    double sBurn = 60.0 // minutes, default
                    Console.WriteLine("hur länge tror du att den brinner?");
                    double.TryParse(Console.ReadLine(), out sBurn); // default:  60 minutes

                    Console.WriteLine("vad är det för märke? (tom sträng om osäker)");
                    String sBrand = Console.ReadLine();
                    if (sBrand.Equals("")) { sBrand = "unknown"; }

                    // TODO:  add MarschallList.Add()  
                    new Marschall(me, sBrand, sa, sb, sc, sd, sBurn); // add to MarschallList  
                    break;
                case 2:
                    IEnumerable<Marschall> active =
                        from x in all
                        where DateTime.Compare(x.BurnTime, DateTime.Now)
                        select x;

                    foreach (Marschall m in active)
                    {
                        Console.WriteLine(m.Print());
                    }
                    break;
                default:
                    foreach (Marschall m in all)
                    {
                        Console.WriteLine(m.Print());
                    }
            }
        }

    }
}