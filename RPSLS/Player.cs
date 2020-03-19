using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
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

            //LIST IS: ROCK = 0, PAPER = 1, SCISSORS = 2, LIZARD = 3, SPOCK = 4

            foreach (string gesture in gestureChoice)
            {
                Console.WriteLine(gesture);
            }
        }



    public virtual void DecidingGesture()
        {
            Console.WriteLine("Get ready to choose your next guesture.");
        }
    }
}