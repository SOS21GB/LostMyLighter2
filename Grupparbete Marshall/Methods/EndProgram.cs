﻿using System;
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
        public static void ExitMarshall()
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

        }


    }
}