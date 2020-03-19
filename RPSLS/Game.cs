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
            Console.WriteLine("HUMAN - CPU - SPECTATE");
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
        }

        //public void ChooseGuestures()

        //    gesturesList = new List<string>();

        //    gesturesList.Add("Choose a guesture: ");
        //    gesturesList.Add("ROCK");
        //    gesturesList.Add("PAPER");
        //    gesturesList.Add("SCISSORS");
        //    gesturesList.Add("LIZARD");
        //    gesturesList.Add("SPOCK");

        //    for (int i = 0; i<gesturesList.Count; i++)
        //    {
        //        Console.WriteLine(gesturesList[i]);
        //    }

        public void RunGame()
        {
            Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK");
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
            gameRules.Add("FIRST PLAYER TO WIN THREE OUT OF FIVE MATCHES WINS!");

            foreach (string rules in gameRules)
            {
                Console.WriteLine(rules);
            }
            Console.ReadLine();

            Console.WriteLine("SELECT GAME MODE:");

            Console.ReadLine();

            ChooseGameMode();


            //playerOne.ChooseGesture();
            //playerTwo.ChooseGesture();

            //Console.WriteLine("Select a gesture for your turn: \n");
            //string move = Console.ReadLine();

            //Console.ReadLine();
        }
    }
}