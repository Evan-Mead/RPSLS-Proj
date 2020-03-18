using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //public Player playerOne;
        //public Player playerTwo;

        //public Game()
        //{
        //    playerOne = new Player();
        //    playerTwo = new Player();
        //}

        public void BetweenTurns()
        {
            Human PlayerOne = new Human("Player One", 0);
            AI PlayerTwo = new AI("Computer", 0);
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

            Console.WriteLine("Select your opponent");
            //if (user picks Human then opponent will be PVP)
            //else (user picks AI then opponet will be PVE)
            //else if (user picks hidden option AI vs AI for NPC battle)
            Console.ReadLine();

            Console.WriteLine("Select a gesture for your turn: \n");
            string move = Console.ReadLine();

            BetweenTurns();
            Console.ReadLine();

            switch (move)
            {
                case "ROCK":
                    Console.WriteLine("You Selected " + move + " as your turn.");
                    break;
                case "PAPER":
                    Console.WriteLine("You Selected " + move + " as your turn.");
                    break;
                case "SCISSORS":
                    Console.WriteLine("You Selected " + move + " as your turn.");
                    break;
                case "LIZARD":
                    Console.WriteLine("You Selected " + move + " as your turn.");
                    break;
                case "SPOCK":
                    Console.WriteLine("You Selected " + move + " as your turn.");
                    break;
                default:
                    Console.WriteLine("Not a valid gesture. Select again.");
                    break;
            }

            if (Console.WriteLine("Not a valid gesture. Select again.")
            {
                Console.WriteLine("Select a gesture for your turn: \n");
            }

                Console.ReadLine();
        }
    }
}