using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int score;
        public string selectedGesture;
        public List<string> gestureChoice;

        public Player()
        {
            List<string> gestureChoice = new List<string>();
            gestureChoice.Add("ROCK");
            gestureChoice.Add("PAPER");
            gestureChoice.Add("SCISSORS");
            gestureChoice.Add("LIZARD");
            gestureChoice.Add("SPOCK");
        }

        public abstract void DecidingGesture();
    }
}