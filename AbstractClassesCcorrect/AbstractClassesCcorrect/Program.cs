using System;

namespace AbstractClassesCcorrect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");

                // as keyword allows items to be defined as different object
                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube");
                }


                //is keyword confirms object or item is a certain class
                if(shape is Cube)
                {
                    Console.WriteLine("This shape is a cube!");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine($"{cube2.Name} has a volume of {cube2.Volume()}");
            }
        }
    }
}
