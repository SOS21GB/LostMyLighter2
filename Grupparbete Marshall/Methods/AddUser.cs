﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //user id saknas

            Console.Write("Ange ditt namn: ");
            try
            {
                user.Name = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Det var inte en korrekt input, försök igen..");
            }


            Console.Write("Ange din ålder: ");
            user.Age = Convert.ToInt32(Console.ReadLine());
            //try user age int parse googla det
            //c försök igen
            //ev loop.

            Console.Write("Ange din Gatuaderss: ");
            user.StreetAddress = Console.ReadLine();

            Console.Write("Ange ditt Postnummer: ");
            user.PostNumber = Convert.ToInt32(Console.ReadLine());

            // Antal sökningar - osäker om de ska vara här
            //Console.Write("Antal sökningar: ");
            user.NumberOfSearch = 0;

            // Antal registerade Marshaller - osäker på hur jag ska få in detta här
            //Console.Write("Antal registerade Marshaller: ");
            user.NumberOfSearch = 0;

            // Antal borttappade tändare - osäker på hur jag ska få in detta här men ska göra ev en count
            //Console.Write("Antal borttappade tändare: ");
            user.LostLighters = 0;

            //Lists.UserList.userList.Add(user);
        }



    }
}
