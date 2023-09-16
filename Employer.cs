using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BossAzConsole
{

    //  Employer
    //  Vacancies

    internal class Employer:Human
    {
        public Vacancy[]? Vacancies { get; set; }


        public Employer(string? name, string? surname, string? city, string? number, int age, string? email, Vacancy[]? vacancies) : base(name, surname, city, number, age, email)
        {
            Vacancies = vacancies;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine("Vacancy(s) : ");
            foreach (Vacancy vacancy in Vacancies)
            {
                vacancy.Show();
            }
        }

    }
}
