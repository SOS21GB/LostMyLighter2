using System;
using static System.Console;

namespace Grupparbete_Marshall
{
    class Program
    {
        static void Main(string[] args)
        {

            Menus.Startmenu start = new Menus.Startmenu();
            start.Start();
          
            Lists.UserList.InitializeUserList();            

        }
    }
}
