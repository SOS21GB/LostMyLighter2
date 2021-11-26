using Grupparbete_Marshall.Classes;

namespace Grupparbete_Marshall
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            User.InitializeUserList();
            Marschall.InitializeMarschallList();
            Menus.Startmenu start = new Menus.Startmenu();
            start.Start();
        }
    }
}