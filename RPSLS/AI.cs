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

            Console.WriteLine("CPU:" + selectedGesture);


            //playerTwoInput.selectedGesture = Console.ReadLine();
        }
    }
}
