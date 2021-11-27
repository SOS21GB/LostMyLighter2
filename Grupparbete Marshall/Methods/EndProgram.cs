using System;
using System.Threading;
using static System.Console;

namespace Grupparbete_Marshall.Methods
{
    internal class EndProgram
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

            if (result.ToUpper() == "YES")
            {
                Console.WriteLine("Thank you for giving us feedback!");
                Console.WriteLine("On a scale of 1 to 5, how much did you enjoy this app?: ");
                int tal = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Thank you for your response");
            }
            else if (result.ToUpper() == "NO")
            {
                Console.Clear();
                Console.WriteLine("Thank you for your time!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fine...");
            }
            Environment.Exit(0);
        }
    }
}