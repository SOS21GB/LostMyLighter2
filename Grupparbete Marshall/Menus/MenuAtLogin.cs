using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Menus
{
    class MenuAtLogin
    {
        static void Main(string[] args)
        {
            
            bool isInvalidInput = false;
           

            //print menue??
            while (!isInvalidInput)
            {
                
                try
                {
                    
                    Console.WriteLine("Ange ditt ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nuvarande Användare: ");  //user list??
                    string name = Console.ReadLine();
                    Console.WriteLine();//separation

                    Console.WriteLine("1. Hitta aktiva marshalls i närheten");
                    Console.WriteLine("2. Lista alla aktiva marshalls ");
                    Console.WriteLine("3. Lägg till ny marshall ");
                    Console.WriteLine("4. Lägg till befintlig marshall");
                    Console.WriteLine();//separation

                    Console.WriteLine("5. Ändra användarinställning");
                    Console.WriteLine("6. Filtrera aktiv marshall");
                    Console.WriteLine("7. Lägg til användare");
                    Console.WriteLine("8. Registrera förlorad tändare");
                    Console.WriteLine("9. Visa profil");
                    Console.WriteLine();//separation

                    Console.WriteLine("0. Avsluta programet");
                    Console.WriteLine("Välj ett alternativ");
                    int option = int.Parse(Console.ReadLine());


                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Hitta aktiva marshalls i närheten");
                            break;
                        case 2:
                            Console.WriteLine("Lista alla aktiva marshalls ");
                            break;
                        case 3:
                            Console.WriteLine("Lägg till ny marshall ");
                            break;
                        case 4:
                            Console.WriteLine("Lägg till befintlig marshall");                        return;
                            break;
                        case 5:
                            Console.WriteLine("Ändra användarinställning");
                            break;
                        case 6:
                            Console.WriteLine("Filtrera aktiv marshall");
                            break;
                        case 7:
                            Console.WriteLine("Filtrera aktiv marshall");
                            break;
                        case 8:
                            Console.WriteLine("Registrera förlorad tändare");
                            break;
                        case 9:
                            Console.WriteLine("Visa profil");
                            break;
                        case 0:
                            Console.WriteLine("Avsluta programet!");
                            break;
                        default:
                            Console.WriteLine("Invalid input, försök igen!");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
         
            Console.ReadLine();
        }
    }
}
