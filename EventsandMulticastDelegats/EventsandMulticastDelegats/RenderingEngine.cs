using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandMulticastDelegats
{
    internal class RenderingEngine
    {

        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }



        // at start of game,
        //we want to enable the rendering engine and start drawing visuals
        private void StartGame()
        {
            Console.WriteLine("Rendering engine started");
            Console.WriteLine("Drawing visuals...");
        }

        //stop rendering when game is over
        private void GameOver()
        {
            Console.WriteLine("Rendering Engine stopped");
        }
    }
}
