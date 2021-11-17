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
        

        //public static void MarshallMenu()

        /* List<Classes.Marschall> all;
        List<Marschall> active;

        static void Run(User me)

        
        static void Run(User me, List<Marschall> all)


        {
            int select = 0;
            do {
                Console.WriteLine("Tryck '1' f?r att l?gga till marschall");
                Console.WriteLine("Tryck '2' f?r att se aktiva marschaller");
                Console.WriteLine("Tryck '3' f?r att se alla marschaller");               
            } while (!int.TryParse(Console.ReadLine(), out select));
            switch (select)


            Console.WriteLine("Tryck '1' f�r att se aktiva marschaller");
            Console.WriteLine("Tryck '2' f�r att se alla marschaller");
            
            if (int.TryParse(Console.ReadLine(), out int select)) 

            Console.WriteLine("Tryck '1' f?r att se aktiva marschaller");
            Console.WriteLine("Tryck '2' f?r att se alla marschaller");
            int select = 0;
            int.TryParse(Console.ReadLine(), out select) == 1;
            if (select == 1)
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
            else
            {
                case 1:
                    Console.WriteLine("p? vilken gata ?r marschallen?");
                    String sa = Console.ReadLine();
                    
                    int sb = 0;
                    do {
                        Console.WriteLine("p? vilket husnummer ?r marschallen?");
                    } while (int.TryParse(Console.ReadLine(), out sb))
                    
                    Console.WriteLine("i vilken kommun ?r marschallen?");
                    String sc = Console.ReadLine();
                   
                    int sd = 0;
                    do { 
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
        */

    }
}