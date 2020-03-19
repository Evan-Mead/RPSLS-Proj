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
            playerOne = new Player();
            playerTwo = new Player();
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
            /*HOW DO I CREATE AN OPTION THAT PROMPTS USER TO RE-TYPE IF WRONG??
             * PROBABLY A BOOL? LOOK INTO IT AFTER MVP*/
        }

        public void ChooseGuestures()
        {
            Console.WriteLine("Select a gesture: \n0 = ROCK\n1 = PAPER\n2 = SCISSORS\n3 = LIZARD\n4 = SPOCK");

            playerOne.DecidingGesture();
            playerTwo.DecidingGesture();

            if (playerOne.selectedGesture == "ROCK" && (playerTwo.selectedGesture == "SCISSORS" || playerTwo.selectedGesture == "LIZARD"))
            {
                Console.WriteLine("Player 1 wins the round.");
            }
            else if (playerOne.selectedGesture == "ROCK" && (playerTwo.selectedGesture == "PAPER" || playerTwo.selectedGesture == "SPOCK"))
            {
                Console.WriteLine("Player 2 wins the round.");
            }
            else if (playerOne.selectedGesture == "PAPER" && (playerTwo.selectedGesture == "ROCK" || playerTwo.selectedGesture == "SPOCK"))
            {
                Console.WriteLine("Player 1 wins the round.");
            }
            else if (playerOne.selectedGesture == "PAPER" && (playerTwo.selectedGesture == "SCISSORS" || playerTwo.selectedGesture == "LIZARD"))
            {
                Console.WriteLine("Player 2 wins the round.");
            }
            else if (playerOne.selectedGesture == "SCISSORS" && (playerTwo.selectedGesture == "PAPER" || playerTwo.selectedGesture == "LIZARD"))
            {
                Console.WriteLine("Player 1 wins the round.");
            }
            else if (playerOne.selectedGesture == "SCISSORS" && (playerTwo.selectedGesture == "ROCK" || playerTwo.selectedGesture == "SPOCK"))
            {
                Console.WriteLine("Player 2 wins the round.");
            }
            else if (playerOne.selectedGesture == "LIZARD" && (playerTwo.selectedGesture == "ROCK" || playerTwo.selectedGesture == "SCISSORS"))
            {
                Console.WriteLine("Player 1 wins the round.");
            }
            else if (playerOne.selectedGesture == "LIZARD" && (playerTwo.selectedGesture == "SPOCK" || playerTwo.selectedGesture == "PAPER"))
            {
                Console.WriteLine("Player 2 wins the round.");
            }
            else if (playerOne.selectedGesture == "SPOCK" && (playerTwo.selectedGesture == "ROCK" || playerTwo.selectedGesture == "SCISSORS"))
            {
                Console.WriteLine("Player 1 wins the round.");
            }
            else if (playerOne.selectedGesture == "SPOCK" && (playerTwo.selectedGesture == "PAPER" || playerTwo.selectedGesture == "LIZARD"))
            {
                Console.WriteLine("Player 2 wins the round.");
            }
            else
            {
                Console.WriteLine("Players TIED.");
            }
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

            Console.ReadLine();
        }
    }
}