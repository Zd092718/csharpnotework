using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_lesson
{
    class BMW:Car
    {

        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        // new keyword associates this show details with the bmw class
        public new void ShowDetails()
        {
            Console.WriteLine($"The color of your BMW {this.Model}is {this.Color}");
            Console.WriteLine($"The Horsepower of your BMW {this.Model} is {this.HP}");
        }
        //override overrides virtual methods
        // sealed  keyword prohibits method from being overridden any further or other inheritance
        public sealed override void Repair()
        {
            Console.WriteLine($"The BMW {this.Model} was repaired!");
        }
    }
}
