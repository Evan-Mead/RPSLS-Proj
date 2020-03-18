using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public string choice;
        public int score;
        public List<string> gestures;

        public Player()
        {
            gestures = new List<string>();

            List<string> gestures = new List<string>();
            gestures.Add("Choose a move:");
            gestures.Add("ROCK");
            gestures.Add("PAPER");
            gestures.Add("SCISSORS");
            gestures.Add("LIZARD");
            gestures.Add("SPOCK");
        }

        public void DisplayGestures()
        {
            foreach (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(gesture[i]);
            }
        }
    }
}