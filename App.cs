using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{
    internal class App
    {
        public static void ShowLoginMenu()
        {
            Console.WriteLine("Enter email : ");
            string email = Console.ReadLine();
            StringBuilder password = new StringBuilder();


            while (true)
            {
                Console.WriteLine("Enter password : ");
                for (int i = 0; i < password.Length; i++){
                    Console.Write("*");
                }


                ConsoleKey key = Console.ReadKey().Key;
                if(key == ConsoleKey.Enter)
                {

                }
                else if (key == ConsoleKey.Backspace)
                {
                    if(password.Length > 0)
                    {
                        password.Remove(password.Length - 1, 1);
                    }
                }
                else
                {
                    password.Append(key.ToString());
                }
                Console.Clear();
            }

        }

        public static void ShowRegisterMenu()
        {
               
        }

        public static void Start()
        {
            Console.Title = "Announcement App";
            
            ShowLoginMenu();
        }
    }
}
