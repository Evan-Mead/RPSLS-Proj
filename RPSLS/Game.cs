using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

        //public Game()
        //{
        //    playerOne = new Human;
        //    playerTwo = new Player;
        //}

        //public void GameMode()
        //{
        //    if player chooses option ONE = PVP;
        //else if player chooses opion TWO = PVE;
        //else = EVE
        //}

        public void PickMove()
        {

        }

        public void GameWinner()
        {

        }

        //mem meth

        public void RunGame()
        {
            Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK");
            Console.ReadLine();

            List<string> instructions = new List<string>();
            instructions.Add("Here are the instructions:");
            instructions.Add("Rock crushes Scissors. Scissors cuts Paper.");
            instructions.Add("Paper covers Rock. Rock crushes Lizard.");
            instructions.Add("Lizard poisons Spock. Spock smashes Scissors.");
            instructions.Add("Scissors decapitates Lizard. Lizard eats Paper.");
            instructions.Add("Paper disproves Spock. Spock vaporizes Rock.");
            instructions.Add("FIRST PLAYER TO WIN THREE OUT OF FIVE MATCHES IN A ROW, WINS!");

            foreach (string instruction in instructions)
            {
                Console.WriteLine(instruction);
            }
        }
    }
}