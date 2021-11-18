using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Methods;
using Grupparbete_Marshall.Classes;

namespace Grupparbete_Marshall.Classes
{
    class Marschall
    {
        public static List<Marschall> marschallList = new List<Marschall>();

        int id;
        string brand;
        double burntime;
        DateTime reg_stamp;
        User reg_user;
        DateTime burnout;
        string streetName;
        int streetNumber;
        string region;
        int postalCode;

        public DateTime Burnout {
            get { return  burnout; }
            set { burnout = value; }
        }
        
        public int PostalCode {
            get { return  postalCode; }
            set { postalCode = value; }
        }

        public User RegUser {
            get { return  reg_user; }
            set { reg_user = value; }
        }
        public Marschall(string _brand, double bTime, int i, string sName, int sNumber,  int pCode)
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
        public Marschall(int i, int id, double bt, DateTime dt, int pc)
        {
            this.id = i;
            this.burntime = bt;
            this.reg_stamp = dt;
            this.postalCode = pc;
            reg_user = User.GetUserById(id);
            burnout = reg_stamp.AddHours(burntime);
        }
        public static void InitializeMarschallList()
        {
            DateTime date1 = new DateTime(2021, 11, 16, 12, 0, 0, 0);

            new Marschall( "Solstickan", 2, 2, "Nergårdsvägen", 43, 43636);
            new Marschall( "Solstickan", 2, 1, "Pilegårdsvägen", 1, 43635);
            new Marschall( "Solstickan", 2, 4, "Tycho Brahes gata", 11, 41517);
            new Marschall(4, 2, 1, date1, 41517);
            new Marschall(5, 3, 1, date1, 43636);
        }
        //Printa aktiva marschaller.
        public static void PrintActiveMarschall() 
        {
            var activeMarshall = marschallList.Where(marshall => marshall.burnout > DateTime.Now);
            foreach (Marschall m in activeMarshall)
            {
                Console.WriteLine("ID {0}", m.id);
                Console.WriteLine("Registered at: {0}", m.reg_stamp);
                Console.WriteLine("Burnes out at: {0}", m.burnout);
                Console.WriteLine("Registered by: {0}", Classes.User.GetUserName(m.reg_user));

                
                //LoginMenu.StartLoginMenu(); Mintamir
            }

        }
    }
}	