using System;
using static System.Console;

namespace Grupparbete_Marshall
{
    class Program
    {
        static void Main(string[] args)
        {
            Lists.UserList.InitializeUserList();
            Menus.Startmenu start = new Menus.Startmenu();
            start.Start();
          
                        

        }
    }
}
