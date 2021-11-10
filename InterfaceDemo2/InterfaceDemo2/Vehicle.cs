using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Vehicle
    {
        public float Speed { get; set; }

        public string Color { get; set; }

        public Vehicle()
        {
            Speed = 38.5f;
            Color = "Green";
        }

        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
