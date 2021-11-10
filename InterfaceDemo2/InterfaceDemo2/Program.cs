using System;

namespace InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair diningChair = new Chair("White", "Wood");
            Chair officeChair = new Chair("Black", "Leather");


            Car damagedCar = new Car(80f, "Blue");

            damagedCar.DestroyablesNearby.Add(diningChair);
            damagedCar.DestroyablesNearby.Add(officeChair);

            damagedCar.Destroy();
        }
    }
}
