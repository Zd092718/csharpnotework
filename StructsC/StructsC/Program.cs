using System;

namespace StructsC
{
    struct Game
    {
        public string name;
        public string dev;
        public double rating;
        public string releaseDate;
        public void DisplayInfo()
        {

            Console.WriteLine($"Game 1's name is {name}");
            Console.WriteLine($"Game 1's developer is {dev}");
            Console.WriteLine($"Game 1's rating is {rating}");
            Console.WriteLine($"Game 1's release date is {releaseDate}");

            //structs do not support inheritence

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // all properties of game 1 need to be assigned and not used as parameters of constructors
            Console.WriteLine("Hello World!");
            Game game1 = new Game();

            game1.name = "Pokemon Go";
            game1.dev = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "1.7.2016";

            game1.DisplayInfo();
            Console.Read();
        }
    }
}
