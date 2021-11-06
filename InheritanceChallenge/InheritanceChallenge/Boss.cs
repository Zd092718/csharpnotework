using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Boss : Employee
    {
        protected string CompanyCar { get; set; }

        public Boss() { }
        public Boss(string lastName, string firstName, int salary, string companyCar)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"My name is {this.FirstName} {this.LastName} and I'm running the show!");
            Console.WriteLine("Time to get to work everybody");
        }
    }
}
