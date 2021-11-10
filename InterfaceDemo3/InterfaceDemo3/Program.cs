using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        // IEnumerable <T> for generic collections
        // IEnumerable for non generic collections

        // <summary>
        // IEnumerable<T> contains a single method  that you must implement when implementing this interface;
        //GetEnumerator(), which returns an IEnumerator<T> object.
        // The returned IEnumerator<T> provides the ability to iterate through a collection
        // by exposing a current property that points at the object we are currently at in the collection.
        public static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach  (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                } else
                {
                    dog.GiveTreat(1);
                }
            }
            Console.Read();
        }
    }

    class Dog
    {

        // name of dog
        public string Name { get; set; }
        //is this a naughty dog
        public bool IsNaughtyDog { get; set; }
        
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        // prints out how many treats the dog received
        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine($"Dog: {Name} said woof {numberOfTreats} times!");
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Grunt", false),
                new Dog("Sparkle", true),
                new Dog("Bear", false),
                new Dog("Benji", false),
            };

        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}