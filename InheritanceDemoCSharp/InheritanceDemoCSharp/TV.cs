using System;

namespace InheritanceDemoCSharp
{
    class TV : Electrical_Device
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }
        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch on first!");
            }
        }
    }
}
