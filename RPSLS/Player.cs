using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        public string name;
        public int score;

        public Player()
        {

        }

        public void PlayerGesture()
        {

        } 

        public virtual void DecidingGesture()
        {
            Console.WriteLine("Get ready to choose your next guesture.");
        }
    }
}