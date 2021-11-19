using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;

namespace Grupparbete_Marshall.Methods
{
    public class changeInuser
    {
        public static void EditUserMethod(User user)
        {
          int userInput = 0;

           do
           {
             Console.WriteLine("Välj vad vill du ändra: ");
             Console.WriteLine("1. Ändra namn");
             Console.WriteLine("2. Ändra ålder");
             Console.WriteLine("3. Ändra adress");

             try
             {
                userInput = Convert.ToInt32(Console.ReadLine()); //anv input
             }
             catch //om de inte skriver in 1-3 elr ngt 
             {
                Console.Clear();
                Console.WriteLine("Du måste välja ett nummer ifrån menyn. Tryck på valfri tangent för att försöka igen: ");
             }

           } while (userInput == 0 || userInput < 3);//kör sålånge input är 0 / mindre än 3

           switch (userInput)
           {
              case 1:
               Console.WriteLine("Ändra namn: ");
               CurrentUser.current.Name = Console.ReadLine();
               break;

              case 2:
                Console.WriteLine("Ändra ålder: ");
                currentuser.current.Age = Convert.ToInt32(Console.ReadLine());
                break;

               case 3:
                Console.WriteLine("Ändra address: ");
                CurrentUser.current.Adress = Console.ReadLine();
                break;
           }      
        }
    }
}