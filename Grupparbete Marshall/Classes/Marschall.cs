using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupparbete_Marshall.Lists;

namespace Grupparbete_Marshall.Classes
{
    class Marschall
    {
        
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


        public Marschall(User user, String _brand, String sName, int sNumber, String sRegion, int pCode, double bTime)
        {
            Random random = new Random();
            id = random.Next(0);
            brand = "unkown";

        public DateTime Burnout {
            get { return burnout ; }
            set { burnout = value; }
        }
        //line to fix merge conflict
        public Marchall(User user,  string _brand, string sName, int sNumber, string sRegion, int pCode, double bTime)
        {
            id = Random.nextint();
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
            MarshallList.all.Add(this);
            
        }
        public string Print() 
        {
            string output = "";
            output += id + "\n";
            return output;
        }
    }
}