using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesCcorrect
{
    abstract class Shape
    {
        public string Name { get; set; }    

        //virtual keyword allows base class method to be
        //inherited and modified with override
        public virtual void GetInfo()
        {
            Console.WriteLine($"\n this is a {Name}");
        }

        public abstract double Volume();
    }
}
