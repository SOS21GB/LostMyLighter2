using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;

namespace Grupparbete_Marshall.Menus
{
    class MarschallMenu
    {

        static void Run(User me, List<Marschall> all)
        {
            int select = 0;
            do
            {
                Console.WriteLine("Tryck '1' f?r att l?gga till marschall");
                Console.WriteLine("Tryck '2' f?r att se aktiva marschaller");
                Console.WriteLine("Tryck '3' f?r att se filtrera efter postkod");
                Console.WriteLine("Tryck '4' f?r att se din marschaller");
                Console.WriteLine("Tryck '5' f?r att se filtrera efter användare");
                Console.WriteLine("Tryck '6' f?r att se alla marschaller");
            } while (!int.TryParse(Console.ReadLine(), out select));
            switch (select)
            {
                case 1:
                    Console.WriteLine("p? vilken gata ?r marschallen?");
                    String sa = Console.ReadLine();

                    int sb = 0;
                    do
                    {
                        Console.WriteLine("p? vilket husnummer ?r marschallen?");
                    } while (int.TryParse(Console.ReadLine(), out sb))


                    Console.WriteLine("i vilken kommun ?r marschallen?");
                    String sc = Console.ReadLine();

                    int sd = 0;
                    do
                    {
                        Console.WriteLine("vilken postnummer har marschallen?");
                    } (int.TryParse(), out sd);

                    double sBurn = 60.0 // minutes, default
                    Console.WriteLine("hur l?nge tror du att den brinner?");
                    double.TryParse(Console.ReadLine(), out sBurn); // default:  60 minutes

                    Console.WriteLine("vad ?r det f?r m?rke? (tom str?ng om os?ker)");
                    String sBrand = Console.ReadLine();
                    if (sBrand.Equals("")) { sBrand = "unknown"; }

                    // TODO:  add MarschallList.Add()  
                    new Marschall(me, sBrand, sa, sb, sc, sd, sBurn); // add to MarschallList  
                    break;
                case 2:
                    foreach (Marschall m in all.Where(x => DateTime.Compare(x.BurnTime, DateTime.Now)))
                    {
                        Console.WriteLine(m.Print());
                    }
                    break;
                case 3:
                    int filterPostalCode = 0;
                    do
                    {
                        Console.WriteLine("välj postnummer");
                    } while (int.TryParse(Console.ReadLine(), out filterPostalCode));

                    foreach (Marschall m in all.Where(x => x.PostalCode == filterPostalCode))
                    {
                        Console.WriteLine(m.Print());
                    }
                    break;
                case 4:
                    foreach (Marschall m in all.Where(x => x.RegUser.Equals(me)))
                    {
                        Console.WriteLine(m.Print());
                    }
                    break;
                case 5:
                    IEnumerable<IGrouping<string, Marschall>> group =
                    all.GroupBy(x => x.RegUser.ID, x => x);
                    foreach (IGrouping<string, Marschall> g in group)
                    {
                        Console.WriteLine(g.Key);
                        foreach (Marschall m in g) { Console.WriteLine(m.Print()); }
                        Console.WriteLine(" ");
                    }
                default:
                    foreach (Marschall m in all)
                    {
                        Console.WriteLine(m.Print());
                    }
            }
        }
    }
}