using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{
    internal class Display
    {
        private static readonly string ITALIC = "\x1B[2m";
        private static readonly string UNDERLINE = "\x1B[4m";
        private static readonly string RESET = "\x1B[0m";

        public static Enum ShowWithvariants(Enum[] variants)
        {

            int selectedOption = 1;

            while (true)
            {
                Console.WriteLine("Select Option : ");
                foreach (var variant in variants)
                {
                    if (selectedOption == Convert.ToInt32(variant))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{UNDERLINE}{Convert.ToInt32(variant)} : {variant}{RESET}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"{Convert.ToInt32(variant)} : {variant}");
                    }
                }



                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.Enter)
                {
                    return variants[selectedOption-1];   
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (selectedOption == variants.Length)
                    {
                        selectedOption = 1;
                    }
                    else
                    {
                        selectedOption++;
                    }
                    Console.Clear();
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    if (selectedOption == 1)
                    {
                        selectedOption = variants.Length;
                    }
                    else
                    {
                        selectedOption--;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Invalid Key");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }

    }
}
