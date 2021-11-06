using System;

namespace InheritanceDemoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.SwitchOff();
            myRadio.ListenRadio();

            TV myTv = new TV(false, "Samsung");
            // method of base class
            myTv.SwitchOn();
            // method of child class
            myTv.WatchTV();
        }
    }
}
