using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public int minPlayerScore = 0;
        public int maxPlayerScore = 3;
        int playerOneScore;
        int playerTwoScore;

        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("HUMAN = 1 | CPU = 2 | SPECTATE = 3");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            if(userInput == "HUMAN" || userInput == "1")
            {
                playerOne = new Human("User 1");
                playerTwo = new Human("User 2");
            }
            else if(userInput == "CPU" || userInput == "2")
            {
                playerOne = new Human("User 1");
                playerTwo = new AI("Cortana");
            }
            else if (userInput == "SPECTATE" || userInput == "3")
            {
                playerOne = new AI("Cortana");
                playerTwo = new AI("GLaDOS");
            }
            else
            {
                ChooseGameMode();
            }
        }

        public void ChooseGuestures()
        {
            playerOne.DecidingGesture();    //GESTURE CHOICE NULL potential string
            playerTwo.DecidingGesture();    //GESTURE CHOICE NULL

            int playerScore = 0;
            while(playerOneScore < 3 && playerTwoScore < 3)
            if (playerOne.selectedGesture == "ROCK" && (playerTwo.selectedGesture == "SCISSORS" || playerTwo.selectedGesture == "LIZARD"))
            {
                Console.WriteLine("Player 1 wins the round.");
                    playerScore += 1;
            }
            else if (playerOne.selectedGesture == "ROCK" && (playerTwo.selectedGesture == "PAPER" || playerTwo.selectedGesture == "SPOCK"))
            {
                Console.WriteLine("Player 2 wins the round.");
                    playerScore += 1;
            }
            else if (playerOne.selectedGesture == "PAPER" && (playerTwo.selectedGesture == "ROCK" || playerTwo.selectedGesture == "SPOCK"))
            {
                Console.WriteLine("Player 1 wins the round.");
                    playerScore += 1;
            }
            else if (playerOne.selectedGesture == "PAPER" && (playerTwo.selectedGesture == "SCISSORS" || playerTwo.selectedGesture == "LIZARD"))
            {
                Console.WriteLine("Player 2 wins the round.");
                    playerScore += 1;
            }
            else if (playerOne.selectedGesture == "SCISSORS" && (playerTwo.selectedGesture == "PAPER" || playerTwo.selectedGesture == "LIZARD"))
            {
                Console.WriteLine("Player 1 wins the round.");
                    playerScore += 1;
            }
            else if (playerOne.selectedGesture == "SCISSORS" && (playerTwo.selectedGesture == "ROCK" || playerTwo.selectedGesture == "SPOCK"))
            {
                Console.WriteLine("Player 2 wins the round.");
                    playerScore += 1;
            }
            else if (playerOne.selectedGesture == "LIZARD" && (playerTwo.selectedGesture == "ROCK" || playerTwo.selectedGesture == "SCISSORS"))
            {
                Console.WriteLine("Player 1 wins the round.");
                    playerScore += 1;
            }
            else if (playerOne.selectedGesture == "LIZARD" && (playerTwo.selectedGesture == "SPOCK" || playerTwo.selectedGesture == "PAPER"))
            {
                Console.WriteLine("Player 2 wins the round.");
                    playerScore += 1; 
            }
            else if (playerOne.selectedGesture == "SPOCK" && (playerTwo.selectedGesture == "ROCK" || playerTwo.selectedGesture == "SCISSORS"))
            {
                Console.WriteLine("Player 1 wins the round.");
                    playerScore += 1;
            }
            else if (playerOne.selectedGesture == "SPOCK" && (playerTwo.selectedGesture == "PAPER" || playerTwo.selectedGesture == "LIZARD"))
            {
                Console.WriteLine("Player 2 wins the round.");
                    playerScore += 1;
            }
            else
            {
                    Console.WriteLine("Players TIED."); //STUCK IN A NEVERENDING LOOP OF "TIED"
            }
            {
                playerScore += 3;
                Console.WriteLine(playerScore); 
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
        }
    }
}