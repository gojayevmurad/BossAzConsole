using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{


    internal class Vacancy
    {
        public string? Title { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public string[]? Keywords { get; set; }

        public Vacancy(string? category, string? city, string[]? keywords)
        {
            Category = category;
            City = city;
            Keywords = keywords;
        }

        public void Show()
        {
            Console.WriteLine("=====Vacancy Info=====");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Category : {Category}");
            Console.WriteLine($"City : {City}");
            Console.WriteLine($"Keyword(s) :");
            foreach (string keyword in Keywords)
            {
                Console.WriteLine($"-{keyword}");
            }
            Console.WriteLine("======================");
        }

    }
}
