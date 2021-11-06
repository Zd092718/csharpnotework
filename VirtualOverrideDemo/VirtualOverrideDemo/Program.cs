using System;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sif", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old!");
            dog.Play();
            dog.Eat();
            dog.MakeSounds();
        }
    }
}
