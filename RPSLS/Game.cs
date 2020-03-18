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
            else if(userInput == "CPU");
            {
                playerOne = new Human("User 1");
                playerTwo = new AI("Cortana");
            }
            ////if(userInput == "SPECTATE")
            ////{
            ////    playerOne = new AI("Cortana", 0);
            ////    playerTwo = new AI("GLaDOS", 0);
            ////}
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

            List<string> instructions = new List<string>();
            instructions.Add("Here are the instructions:");
            instructions.Add(" ");
            instructions.Add("ROCK crushes SCISSORS. SCISSORS cuts PAPER.");
            instructions.Add("PAPER covers ROCK. ROCK crushes LIZARD.");
            instructions.Add("LIZARD poisons SPOCK. SPOCK smashes SCISSORS.");
            instructions.Add("SCISSORS decapitates LIZARD. LIZARD eats PAPER.");
            instructions.Add("PAPER disproves SPOCK. SPOCK vaporizes ROCK.");
            instructions.Add(" ");
            instructions.Add("FIRST PLAYER TO WIN THREE OUT OF FIVE MATCHES IN A ROW, WINS!");

            foreach (string instruction in instructions)
            {
                Console.WriteLine(instruction);
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