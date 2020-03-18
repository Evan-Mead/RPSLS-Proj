using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

        public Game()
        {
            
        }

        //public void ChooseGameMode()
        //{
        //    Console.WriteLine("Select Game Mode");
        //    string userInput = Console.ReadLine();
        //    playerOne = new Human();
        //    playerTwo = new AI();
        //}
        //if (user picks Human then opponent will be PVP)
        //else (user picks AI then opponet will be PVE)
        //*else if (user picks hidden option AI vs AI for NPC battle)*//

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

            //Console.ReadLine();

            //ChooseGameMode();

            //playerOne.ChooseGesture();
            //playerTwo.ChooseGesture();

            //Console.WriteLine("Select a gesture for your turn: \n");
            //string move = Console.ReadLine();

            //Console.ReadLine();
        }
    }
}