using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Furniture() 
        {
            Color = "White";
            Material = "Wood";
        }

        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
