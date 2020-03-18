using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class AI : Player
    {
        public AI(string name, int score, string gesturesList)
        {
            this.name = name;
            score = 0;
            this.gesturesList = new List<string>();
        }

        public override void DecidingGuesture()
        {
            Console.WriteLine("CPU is running schematics...");
        }

        public override void ChooseGuestures()
        {
            gesturesList.Add("Choose a guesture: ");
            gesturesList.Add("ROCK");
            gesturesList.Add("PAPER");
            gesturesList.Add("SCISSORS");
            gesturesList.Add("LIZARD");
            gesturesList.Add("SPOCK");

            for (int i = 0; i < gesturesList.Count; i++)
            {
                Console.WriteLine(gesturesList[i]);
            }
        }
    }
}
