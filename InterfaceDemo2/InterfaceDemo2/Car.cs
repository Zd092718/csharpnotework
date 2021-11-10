using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Car : Vehicle, IDestroyable
    {
        //Implementing interface property
        public string DestructionSound { get; set; }


        //new property to store destroyable objects nearby
        public List<IDestroyable> DestroyablesNearby;


        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Create fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
