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
            Console.WriteLine("CPU is running schematics...");
            Console.WriteLine("ROCK, PAPER, SCISSORS, LIZARD, SPOCK...SHOOT!:");

            selectedGesture = Console.ReadLine();   //UNSURE OF HOW/WHERE THIS GOES
            Random pick = new Random(); //NOT RANDOMIZING
            int n = pick.Next(0, 4);    //WHERE DO I GO??
        }
    }
}