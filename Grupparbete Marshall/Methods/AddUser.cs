﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Classes;
using Grupparbete_Marshall.Lists;

namespace Grupparbete_Marshall.Methods
{
    class AddUser
    //metod skapa anv:
    //Skapa ett objekt från klassen user

    {
        //try catcha allt

        public static void AddUsers()
        {
            Classes.User user = new Classes.User(); //instancierat, först hänvisa t mappen classes sen till klassen man vill använda

            

            Console.Write("Ange ditt namn: ");
            user.Name = Console.ReadLine();


            Console.Write("Ange din ålder: ");

            try
            {
                //user.Age = Convert.ToInt32(Console.ReadLine());
                user.Age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            //try user age int parse googla det
            //ev loop.

            Console.Write("Ange din Gatuaderss: ");
            try
            {
                user.StreetAddress = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }

            Console.Write("Ange ditt Postnummer: ");
            try
            {
               // user.PostNumber = Convert.ToInt32(Console.ReadLine());
                user.PostNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }


            
            UserList.UserId = user.Id;
        }



    }
}
