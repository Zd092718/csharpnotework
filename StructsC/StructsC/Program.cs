using System;

namespace StructsC
{
    struct Game
    {
        public string name;
        public string dev;
        public double rating;
        public string releaseDate;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game game1 = new Game();

            game1.name = "Pokemon Go";
            game1.dev = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "1.7.2016";

            Console.WriteLine($"Game 1's name is {game1.name}");

        }
    }
}
