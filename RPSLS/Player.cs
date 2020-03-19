using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int score;
        public string selectedGesture = Console.ReadLine(); //UNSURE OF HOW/WHERE THIS GOES 
        public List<string> gestureChoice;

        public Player()
        {
            List <string> gestureChoice = new List<string>();
            Console.WriteLine("Select a gesture: 0 = ROCK | 1 = PAPER | 2 = SCISSORS | 3 = LIZARD | 4 = SPOCK");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            foreach (string gesture in gestureChoice)
            {
                Console.WriteLine(gesture);
            }
        }
        public abstract void DecidingGesture();
    }
}