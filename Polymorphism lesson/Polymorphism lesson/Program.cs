using System;
using System.Collections.Generic;
using System.Linq;

namespace Polymorphism_lesson 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(300, "red", "M4"),
            };
            foreach (var car in cars)
            {
                car.Repair();
            }

            BMW m8 = new BMW(600, "black", "M8");
            Audi s6 = new Audi(600, "white", "S6");
            m8.ShowDetails();
            s6.ShowDetails();

            m8.SetCarIDInfo(1234, "Zack");
            s6.SetCarIDInfo(1453, "Allie T");
            m8.GetCarIdInfo();
            s6.GetCarIdInfo();


            M3 myM3 = new M3(200, "red", "M3 Super");
            myM3.Repair();





        }
    }
}