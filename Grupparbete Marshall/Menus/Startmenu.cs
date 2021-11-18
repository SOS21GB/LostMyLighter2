using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Grupparbete_Marshall.Classes;
using Grupparbete_Marshall.Methods;

namespace Grupparbete_Marshall.Menus
{
    class Startmenu 
    { 
        private void RunStartMenu() 
        {
            string prompt = @"

   _____                            .__           .__  .__       _____             .___                           
  /     \ _____ _______ ______ ____ |  |__ _____  |  | |  |     /     \ _____    __| _/____   ____   ______ ______
 /  \ /  \\__  \\_  __ /  ____/ ___\|  |  \\__  \ |  | |  |    /  \ /  \\__  \  / __ |/    \_/ __ \ /  ___//  ___/
/    Y    \/ __ \|  | \\___ \\  \___|   Y  \/ __ \|  |_|  |__ /    Y    \/ __ \/ /_/ |   |  \  ___/ \___ \ \___ \ 
\____|__  (____  |__| /____  >\___  |___|  (____  |____|____/ \____|__  (____  \____ |___|  /\___  /____  /____  >
        \/     \/          \/     \/     \/     \/                    \/     \/     \/    \/     \/     \/     \/ 

use the up and down arrowkeys and enter!";
            string[] options = { "Log in", "Create new user", "Exit" };
            Menu startMenu = new Menu(prompt, options);
            int SelectedIndex = startMenu.run();
            switch (SelectedIndex) 
            {
                case 0:
                    LoginUser.UserLogin();
                    break;
                case 1:
                    AddUser.AddUsers();
                    break;
                case 2:
                    ExitMarshall();
                    break;
            }
        }
       
      
       
        private void ExitMarshall() 
        {
            WriteLine("\n Press any key to exit the app");
            ReadKey(true);
            Environment.Exit(0);
        }




        public void Start() 
        {
            RunStartMenu();
          
        }
    }
}
