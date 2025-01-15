using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeOOP
{
    internal class Student : BasePerson
    {
        public int IdNum { get; set; }

        public void IntroduceStudent()
        {
            Introduce();
            Console.WriteLine($"Ogrenci No : {IdNum}");


        }
    
    }

}
