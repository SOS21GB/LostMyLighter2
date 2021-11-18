using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Methods;

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
        public Marschall(User user,  string _brand, string sName, int sNumber, string sRegion, int pCode, double bTime)
        {
            id = marschallList.Count + 1;
            brand = _brand;

            reg_stamp = DateTime.Now;
            reg_user = user;
            burntime = bTime;
            burnout = reg_stamp.AddMinutes(burntime);

            streetName = sName;
            streetNumber = sNumber;
            region = sRegion;
            postalCode = pCode;
            brand = _brand;
            marschallList.Add(this);
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

                Console.WriteLine();
                User.AddSearch(LoginUser.currentUser);
                Console.WriteLine("Press any button to return to the menu and clear the console.");
                Console.ReadKey();
                Console.Clear();
                //LoginMenu.StartLoginMenu(); Mintamir
            }

        }
    }
}	