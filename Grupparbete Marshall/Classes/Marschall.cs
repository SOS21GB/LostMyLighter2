using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public DateTime Burnout
        {
            get { return burnout; }
            set { burnout = value; }
        }

        //line to fix merge conflict
        public Marschall(User user, string _brand, string sName, int sNumber, string sRegion, int pCode, double bTime)
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

    }
}