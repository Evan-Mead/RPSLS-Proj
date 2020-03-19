using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
        }

        public override void DecidingGesture()
        {
            Console.WriteLine("{0} is thinking...", name);
            Console.WriteLine("ROCK, PAPER, SCISSORS, LIZARD, SPOCK...SHOOT!:");
            selectedGesture = Console.ReadLine();   //UNSURE OF HOW/WHERE THIS GOES
        }
    }
}