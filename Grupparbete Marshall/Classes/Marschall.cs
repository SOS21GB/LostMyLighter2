using System;
using System.Collections.Generic;
using System.Linq;

namespace Grupparbete_Marshall.Classes
{
    internal class Marschall
    {
        public static List<Marschall> marschallList = new List<Marschall>();

        private int id;
        private string brand;
        private double burntime;
        private DateTime reg_stamp;
        private User reg_user;
        private DateTime burnout;
        private string streetName = "unknown";
        private int streetNumber;
        private string region;
        private int postalCode;

        public DateTime Burnout
        {
            get { return burnout; }
            set { burnout = value; }
        }

        public int PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public User RegUser
        {
            get { return reg_user; }
            set { reg_user = value; }
        }

        public Marschall(string _brand, double bTime, int i, string sName, int sNumber, int pCode)
        {
            id = marschallList.Count + 1;
            brand = _brand;
            reg_stamp = DateTime.Now;
            reg_user = User.GetUserById(i);
            burntime = bTime;
            burnout = reg_stamp.AddMinutes(burntime);
            streetName = sName;
            streetNumber = sNumber;
            postalCode = pCode;
            marschallList.Add(this);
        }

        public Marschall(string bn, int id, double bt, DateTime dt, int pc)
        {
            this.id = marschallList.Count + 1;
            this.brand = bn;
            this.burntime = bt;
            this.reg_stamp = dt;
            this.postalCode = pc;
            reg_user = User.GetUserById(id);
            burnout = reg_stamp.AddHours(burntime);
            marschallList.Add(this);
        }

        public static void InitializeMarschallList()
        {
            DateTime date1 = new DateTime(2021, 11, 16, 12, 0, 0, 0);

            new Marschall("Solstickan", 60, 2, "Nergårdsvägen", 43, 43636);
            new Marschall("Solstickan", 60, 1, "Pilegårdsvägen", 1, 43635);
            new Marschall("Solstickan", 120, 4, "Tycho Brahes gata", 11, 41517);
            new Marschall("Sostickan", 2, 1, date1, 41517);
            new Marschall("Solstickan", 3, 1, date1, 43636);
        }

        public static void PrintAllMarschalls()
        {
            foreach (Marschall m in marschallList)
            {
                PrintMarschall(m);
            }

            Console.WriteLine("Press any key to clear console and return to main menu...");
            Console.ReadKey();
            Console.Clear();
            Menus.MenuAtLogin.LoginMenu();
        }

        public static void PrintMarschall(Marschall marschall)
        {
            Console.WriteLine("ID:{0}", marschall.id);
            Console.WriteLine("Brand:{0}", marschall.brand);
            Console.WriteLine("Street:{0} {1}", marschall.streetName, marschall.streetName == "unknown" ? "" : marschall.streetNumber);
            Console.WriteLine("Postalcode:{0}", marschall.postalCode);
            Console.WriteLine("Registered by: {0}", User.GetUserName(marschall.reg_user));
            Console.WriteLine();
        }

        public static void PrintActiveMarschall()
        {
            var activeMarschall = marschallList.Where(marschall => marschall.burnout > DateTime.Now);
            foreach (Marschall m in activeMarschall)
            {
                PrintMarschall(m);
            }

            Console.WriteLine("Press any key to clear console and return to main menu...");
            Console.ReadKey();
            Console.Clear();
            Menus.MenuAtLogin.LoginMenu();
        }
    }
}