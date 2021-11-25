﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Grupparbete_Marshall.Menus
{
    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;

        }

        private void DisplayOptions()

        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = ">";
                    ForegroundColor = ConsoleColor.Red;
                    BackgroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.DarkYellow;
                    BackgroundColor = ConsoleColor.DarkRed;
                }

                WriteLine($"{prefix}<< {currentOption} >>");
            }
            ResetColor();
        }

        public int run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                Console.Beep();

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }

    }
}
