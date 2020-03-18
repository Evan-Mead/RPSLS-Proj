using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int score;
        public List<string> gesturesList;

        public Player()
        {
            gesturesList = new List<string>();
        }

        public void ChooseMove()
        {
            Console.WriteLine("Get ready to choose your next guesture.");
        }

        public abstract void DecidingGuesture();

        public abstract void ChooseGuestures();
    }
}