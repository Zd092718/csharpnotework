using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandMulticastDelegats
{
    class GameEventManager
    {
        public delegate void GameEvent();

        public static event GameEvent OnGameStart, OnGameOver;


        public static void TriggerGameStart()
        {
            //check if ongamestart event is not empty
            //meaning that other methods subscribed to it
            if(OnGameStart != null)
            {
                Console.WriteLine("The game has started...");
                //call ongamestart which triggers all methods subscribed to it
                OnGameStart();  
            }
        }

        public static void TriggerGameOver()
        {
            //check if ongamestart event is not empty
            //meaning that other methods subscribed to it
            if (OnGameOver != null)
            {
                Console.WriteLine("The game has ended...");
                OnGameOver();
            }
        }
    }
}
