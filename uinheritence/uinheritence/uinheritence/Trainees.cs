using System;
using System.Collections.Generic;
using System.Text;

namespace uinheritence
{
    class Trainees:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

       

        public Trainees(int workingHours, int schoolHours, string name, string firstname, int salary) : base(name,firstname,salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours in school", SchoolHours);

        }

        public void Work()
        {
            Console.WriteLine("I'm working for {0} hours.", WorkingHours);

        }
    }

}
