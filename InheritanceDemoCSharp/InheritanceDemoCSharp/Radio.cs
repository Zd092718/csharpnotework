using System;

namespace InheritanceDemoCSharp
{
    class Radio : Electrical_Device
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
        }
        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch on first!");
            }
        }
    }
}
