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

            //Random rnd = new Random();
            //int n = rnd.Next(4);

            //playerTwoInput = Console.ReadLine();

            //Console.WriteLine("CPU:" + gestureChoice[n]);

            selectedGesture = Console.ReadLine();
        }
    }
}
