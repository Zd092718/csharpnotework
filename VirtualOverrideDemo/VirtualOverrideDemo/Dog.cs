using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Dog : Animal
    {

        public bool IsHappy { get; set; }

        public Dog(string name, int age): base(name, age)
        {
            IsHappy = true;
        }

        // override of virtual method Eat

        public override void Eat()
        {
            // to call eat method from base class use base keyword
            base.Eat();
        }

        // override of virtual method makeSounds
        public override void MakeSounds()
        {
            Console.WriteLine("Woof!");
        }


        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine($"{Name} doesn't want to play!");
            }
        }
    }
}
