using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        public Player playerOne;
        public Player playerTwo;

        public Game()
        {

        }

        public void ChooseGameMode()
        {
            Console.WriteLine("HUMAN = 1 | CPU = 2 | SPECTATE = 3");
            string userInput = Console.ReadLine();

            if(userInput == "Human")
            {
                playerOne = new Human("User 1");
                playerTwo = new Human("User 2");
            }
            else if(userInput == "CPU")
            {
                playerOne = new Human("User 1");
                playerTwo = new AI("Cortana");
            }
            if (userInput == "SPECTATE")
            {
                playerOne = new AI("Cortana");
                playerTwo = new AI("GLaDOS");
            }
            //HOW DO I CREATE AN OPTION THAT PROMPTS USER TO RE-TYPE IF WRONG??
        }

        public void ChooseGuestures()
        {
            Console.WriteLine("Select a gesture: \n1 = ROCK\n2 = PAPER\n3 = SCISSORS\n4 = LIZARD\n5 = SPOCK");
            string[] gestureChoice = new string[5] { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
            Random rnd = new Random();
            int n = rnd.Next(0, 5);
            Console.WriteLine("Enter your selection:");
            string userInput = Console.ReadLine();
            Console.WriteLine("CPU:" + gestureChoice[n]);

            //MAKE A LOOP FOR TURNS
        }
        public void RunGame()
        {
            Console.WriteLine("ROCK - PAPER - SCISSORS - LIZARD - SPOCK");
            Console.ReadLine();

            List<string> gameRules = new List<string>();
            gameRules.Add("Here are the game rules:");
            gameRules.Add(" ");
            gameRules.Add("SCISSORS cuts PAPER");
            gameRules.Add("PAPER covers ROCK.");
            gameRules.Add("ROCK smashes LIZARD.");
            gameRules.Add("LIZARD poisons SPOCK.");
            gameRules.Add("SPOCK smashes SCISSORS.");
            gameRules.Add("SCISSORS decapitates LIZARD.");
            gameRules.Add("LIZARD eats PAPER.");
            gameRules.Add("PAPER disproves SPOCK.");
            gameRules.Add("SPOCK vaporizes ROCK.");
            gameRules.Add("And, as it always has, ROCK smashes SCISSORS.");
            gameRules.Add(" ");
            gameRules.Add("FIRST PLAYER TO WIN THREE ROUNDS WINS!");

            foreach (string rules in gameRules)
            {
                Console.WriteLine(rules);
            }
            Console.ReadLine();

            Console.WriteLine("INPUT YOUR SELECTION, AND PRESS ENTER TO SELECT YOUR OPPONENT:");

            ChooseGameMode();

            ChooseGuestures();


            //Console.WriteLine("Select a gesture for your turn: \n");
            //string move = Console.ReadLine();

            //Console.ReadLine();
        }
    }
}