using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{
    internal class Worker :Human
    {

        public CV[]? CVList { get; set; }

        public Worker(string? name, string? surname, string? city, string? number, int age, string? email , CV[]? cVlist) 
            : base(name, surname, city, number, age, email)
        {
            this.CVList = cVlist;
        }

        public new void Show()
        {
            base.Show();
            foreach (var cv in CVList)
            {
                cv.Show();
            }
        }
        
    }
}
