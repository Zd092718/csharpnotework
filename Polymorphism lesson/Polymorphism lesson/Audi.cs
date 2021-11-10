using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_lesson
{
    class Audi:Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"The color of your Audi {this.Model} is {this.Color}");
            Console.WriteLine($"The Horsepower of your Audi {this.Model} is {this.HP}");
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi was repaired!");
        }
    }
}
