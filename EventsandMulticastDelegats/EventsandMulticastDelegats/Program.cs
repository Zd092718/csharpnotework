using System;

namespace EventsandMulticastDelegats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create audio system
            AudioSystem audioSystem = new AudioSystem();
            //create renderingengine
            RenderingEngine engine = new RenderingEngine();

            Player player1 = new Player("SteelCow");
            Player player2 = new Player("CptPtag");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running... press any key to end game");
            Console.ReadLine();

            GameEventManager.TriggerGameOver();
        }
    }
}
