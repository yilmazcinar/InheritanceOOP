using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeOOP
{
    internal class Teacher : BasePerson
    {
        public decimal Salary { get; set; }




        public void IntroduceTeacher()
        {
            Introduce();
            Console.WriteLine($"Maaş : {Salary}");
        }
    }
}
