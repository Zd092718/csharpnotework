using System;

namespace InheritanceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss bossMan = new Boss("Dowd", "Zack", 66000, "Land Rover");
            bossMan.Lead();
            Trainee newbie = new Trainee("Burton", "Gavin", 45000, 20, 30);
            newbie.Work();
            newbie.Learn();
            newbie.Pause();
            Console.Read();
        }
    }
}
