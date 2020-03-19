using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class AI : Player
    {
        public AI(string name)
        {
            this.name = name;
        }

        public override void DecidingGesture()
        {
            Console.WriteLine("CPU is running schematics...", name);
            Console.WriteLine("ROCK, PAPER, SCISSORS, LIZARD, SPOCK...SHOOT!:");

            Console.WriteLine("Select a gesture: \n1 = ROCK | \n2 = PAPER | \n3 = SCISSORS | \n4 = LIZARD |\n5 = SPOCK");
            string[] gestureChoice = new string [5] { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
            Random pick = new Random();
            int n = pick.Next(1, 5);

            //call the lsit and make it appropriate for randomization
            selectedGesture = Console.ReadLine();   //UNSURE OF HOW/WHERE THIS GOES
        }
    }
}