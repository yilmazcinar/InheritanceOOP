using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeOOP
{
    public class BasePerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }


        public void Introduce()
        {
            Console.WriteLine($"Ad : {Name}\n\nSoyad : {LastName}\n");
        }

    }
}
