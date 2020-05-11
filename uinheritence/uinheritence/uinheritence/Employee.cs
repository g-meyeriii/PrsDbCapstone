using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace uinheritence
{
    class Employee
    {

        protected string FirstName { get; set; }
        protected string Name { get; set; }
        protected int Salary { get; set; }

        public Employee(string name, string firstName, int salary ) 
        {
            this.FirstName = firstName;
            this.Name = name;
            this.Salary = salary;
        
        }

        public Employee() 
        {
            Name = "Meyer";
            FirstName = "George";
            Salary = 50000;

        }

        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm not working");
        }

    }

    

}
