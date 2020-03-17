using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        public string name;
        public int score;

        public List<Human> playerOne;
        public List<AI> playerTwo;

    public Player()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Choose a move:");
            gestures.Add("ROCK");
            gestures.Add("PAPER");
            gestures.Add("SCISSORS");
            gestures.Add("LIZARD");
            gestures.Add("SPOCK");

            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }

        public void MoveChoice()
        {
            Console.WriteLine("{0} is choosing a move.", name);
            /* moves go here
             * ROCK
             * PAPER
             * SCISSORS
             * LIZARD
             * SPOCK
             */
        }
    }
}
