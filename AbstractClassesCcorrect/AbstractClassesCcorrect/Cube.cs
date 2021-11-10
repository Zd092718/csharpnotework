using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesCcorrect
{
    internal class Cube : Shape
    {

        public int Length { get; set; }
        public Cube(int length)
        {
            Name = "Cube";
            this.Length = length;
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo(); 
            Console.WriteLine($"The cube has a length of {Length}.");
        }
    }
}
