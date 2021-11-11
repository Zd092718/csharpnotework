using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandMulticastDelegats
{
    internal class AudioSystem
    {
        public AudioSystem()
        {
            // subscribe to ongamestart and ongameover events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

       

        //enable audio and play audio when game starts
        private void StartGame()
        {
            Console.WriteLine("Audio System Started...");
            Console.WriteLine("Playing Audio...");
        }

        //stop audio system when game is over
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
