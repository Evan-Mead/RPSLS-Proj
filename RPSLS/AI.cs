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

            var random = new Random();
            {
                var list = new List<string> { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
                int index = random.Next(list.Count);
                Console.WriteLine(name + " picked " + list[index]);
            }
            
            //selectedGesture = Console.ReadLine();
        }
    }
}