using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Trainee: Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee() { }

        public Trainee(string lastName, string firstName, int salary, int workingHours, int schoolHours)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} has been studying for {this.SchoolHours} hours!");
        }

        public override void Work()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} has worked for {this.WorkingHours} hours!");
        }
    }
}
