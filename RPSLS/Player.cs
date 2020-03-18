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
        public List<string> gesturesList;

        public Player()
        {
            gesturesList = new List<string>();

            gesturesList.Add("Choose a move:");
            gesturesList.Add("ROCK");
            gesturesList.Add("PAPER");
            gesturesList.Add("SCISSORS");
            gesturesList.Add("LIZARD");
            gesturesList.Add("SPOCK");
        }

        public void ChooseGestures()
        {
            for (int i = 0; i < gesturesList.Count; i++)
            {
                Console.WriteLine(gesturesList[i]);
            }
        }
    }
}