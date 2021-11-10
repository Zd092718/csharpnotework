using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_lesson
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }


        //Has a relationship
        protected CarInfo carIdInfo = new CarInfo();

        public void SetCarIDInfo(int IdNum, string owner)
        {
            carIdInfo.IDNum = IdNum;
            carIdInfo.OwnerName = owner;
        }

        public void GetCarIdInfo()
        {
            Console.WriteLine($"The car has the id of {carIdInfo.IDNum} " +
                $"and is owned by {carIdInfo.OwnerName}");
        }
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The color of the car is {this.Color}");
            Console.WriteLine($"The Horsepower of the car is {this.HP}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
