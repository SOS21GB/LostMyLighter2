
using System;
using Grupparbete_Marshall.Classes;
using static System.Console;


namespace Grupparbete_Marshall
{
    class Program
    {
        static void Main(string[] args)
       
        {

            User.InitializeUserList();
            Marschall.InitializeMarschallList();
            Menus.Startmenu start = new Menus.Startmenu();
            start.Start(); 
        }


    }

}
