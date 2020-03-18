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
            public List<string> guesturesList;
        }

        public string ChooseGameMode(string output)
        {
            Console.WriteLine(output); 
            string userChooseGameMode = (Console.ReadLine());
            return Console.ReadLine();
        }

        public void SelectPlayers(string playerSelect)
        {
            if (playerSelect == "Human")
            {
                playerOne = new Human("User 1", 0, );
                playerTwo = new Human("User 2", 0, );
            }
            else if (playerSelect == "CPU");
            {
                playerOne = new Human("User 1", 0, );
                playerTwo = new AI("Cortana", 0, );
            }
            else
            {
                playerOne = new AI("Cortana", 0, );
                playerTwo = new AI("GLaDOS", 0, );
            }
        }

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

            Console.WriteLine("SELECT GAME MODE: ");

            string userChooseGameMode = ChooseGameMode("HUMAN - CPU - SPECTATE");

            //playerOne.ChooseGesture();
            //playerTwo.ChooseGesture();

            //Console.WriteLine("Select a gesture for your turn: \n");
            //string move = Console.ReadLine();

            //Console.ReadLine();
        }
    }
}