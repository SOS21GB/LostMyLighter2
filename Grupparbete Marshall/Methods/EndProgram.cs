using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;
using Grupparbete_Marshall.Menus;


namespace Grupparbete_Marshall.Methods
{
    class EndProgram
    {
        public static void ExitMarschall()
        {


            string text = @"
______________ ______________    ___________ _______  ________ ._.
\__    ___/   |   \_   _____/    \_   _____/ \      \ \______ \| |
  |    | /    ~    \    __)_      |    __)_  /   |   \ |    |  \ |
  |    | \    Y    /        \     |        \/    |    \|    `   \|
  |____|  \___|_  /_______  /    /_______  /\____|__  /_______  /_
                \/        \/             \/         \/        \/\/
";

            for (int i = 0; i < 5; i++)
            {
                WriteLine(text);
                Thread.Sleep(500);
                Clear();
                Thread.Sleep(100);
            }

            WriteLine("\n Press any key to exit the program");
            ReadKey(true);

            Console.WriteLine("Give us feedback? [YES/NO] ");
            string result = Console.ReadLine();

            if (result == "YES")
            {
                Console.WriteLine("Thank you for giving us feedback!");
                Console.WriteLine("Scale 1 to 5, How you thaught it was?: ");
                int tal = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Thank you for your response");
            }


            else if (result == "NO")
            {
                Console.WriteLine("Thank you for your time!");
            }
        }


    }
}