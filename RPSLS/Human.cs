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

            Console.WriteLine("Select a gesture: \n1 = ROCK | \n2 = PAPER | \n3 = SCISSORS | \n4 = LIZARD |\n5 = SPOCK");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            //gestureChoice = //?? for why again?

            //selectedGesture = List;   //HOW DO I CALL THE LIST??
        }
    }
}