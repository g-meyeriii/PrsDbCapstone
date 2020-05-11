using System;
using System.Collections.Generic;
using System.Text;

namespace uinheritence
{
    class Boss:Employee
    {
        public string CompanyCar { get; set; }

       
        
        public Boss(string name, string firstName, int salary, string companyCar): base(name, firstName,salary)
        {
                      
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I'm the leader! My name is {0} {1}", FirstName, Name);
        }


    }
}
