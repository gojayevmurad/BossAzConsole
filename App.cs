using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{
    internal class App
    {
        static bool isWorker;

        private static void getUserType()
        {
            bool loop;

            do
            {
                Console.WriteLine("Worker(w) <=> Employer(e)");

                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();

                loop = false;

                if (key == ConsoleKey.W)
                {
                    isWorker = true;
                }
                else if (key == ConsoleKey.E)
                {
                    isWorker = false;
                }
                else
                {
                    loop = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Key");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (loop); ;
        }

        public static void ShowLoginMenu()
        {
            Console.WriteLine("Enter email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password : ");
            StringBuilder password = new StringBuilder();

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if(key != ConsoleKey.Enter)
                {

                }
                else if (key != ConsoleKey.Backspace)
                {

                }
                else
                {
                    password.Append(key.ToString());
                }
            }

        }

        

        public static void Start()
        {
            Console.Title = "Announcement App";
            getUserType();
            
            ShowLoginMenu();
        }
    }
}
