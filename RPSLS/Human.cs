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

            
            List<string> playerChoice = new List<string>();
            playerChoice.Add("ROCK"); 
            playerChoice.Add("PAPER"); 
            playerChoice.Add("SCISSORS"); 
            playerChoice.Add("LIZARD"); 
            playerChoice.Add("SPOCK");
            Console.WriteLine(name + " picked " + " ");
            Console.ReadLine();

            //selectedGesture = List;   //HOW DO I CALL THE LIST??
        }
    }
}