using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Employee
    {
        protected string LastName { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }


        public Employee() { }
        public Employee(string lastName, string firstName, int salary)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("I'm Working!");
        }

        public virtual void Pause()
        {
            Console.WriteLine("I'm off!");
        }
    }
}
