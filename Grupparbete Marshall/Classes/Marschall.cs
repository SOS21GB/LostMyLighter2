using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_Marshall.Classes
{
    class Marschall
    {
        int id;
        String brand;
        double burntime;
        DateTime reg_stamp;
        User reg_user;
        DateTime burnout;
        String streetName;
        int streetNumber;
        String region;
        int postalCode;
        
        public DateTime Burnout { 
            get {   return burnout;   } 
            set {   burnout = value;  }
        }

        public Marchall(User user, String sName, int sNumber, String sRegion, int pCode, double bTime)
        {
            id = Random.nextint();
            brand = "unkown";
            reg_stamp = DateTime.Now;
            reg_user = user;
            burntime = bTime;
            burnout = reg_stamp.AddMinutes(burntime);

            streetName = sName;
            streetNumber = sNumber;
            region = sRegion;
            postalCode pCode;
        }
        
        public Marchall(User user, String _brand String sName, int sNumber, String sRegion, int pCode, double bTime)
        {
            Marchall(User user, String sName, int sNumber, String sRegion, int pCode, double bTime)
            brand = _brand;
        }

    }
}