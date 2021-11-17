using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;


namespace Grupparbete_Marshall.Methods
{
    class AddUser
    //metod skapa anv:
    //Skapa ett objekt från klassen user

    {
        //try catcha allt

        public static void AddUsers()
        {

            int age = 0;
            int postNumber = 0;

            Console.Write("Ange ditt namn: ");
            string name = Console.ReadLine();


            Console.Write("Ange din ålder: ");

            try
            {
                //user.Age = Convert.ToInt32(Console.ReadLine());
                age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            //try user age int parse googla det
            //ev loop.

            Console.Write("Ange din Gatuaderss: ");
           
            string streetAddress = Console.ReadLine();
            
          

            Console.Write("Ange ditt Postnummer: ");
            try
            {
               // user.PostNumber = Convert.ToInt32(Console.ReadLine());
                postNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            User user = new User(name, age, streetAddress, postNumber);

        }



    }
}
