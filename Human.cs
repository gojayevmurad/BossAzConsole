using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{
    abstract internal class Human
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
        public string? Number { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public int Id { get; } = ++_id;

        private static int _id = 0;

        public Human(string? name, string? surname, string? city, string? number, int age, string? email)
        {

            Name = name;
            Surname = surname;
            City = city;
            Number = number;
            Age = age;
            Email = email;
        }

        public void Show()
        {
            Console.WriteLine("===User Info===");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"City : {City}");
            Console.WriteLine($"Number : {Number}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Email : {Email}");
        }

    }
}
