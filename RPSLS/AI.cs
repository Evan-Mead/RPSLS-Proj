using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class AI : Player
    {
        public AI(string name, string choice, int score, string gestures)
        {
            this.name = name;
            this.choice = choice;
            score = 0;
            this.gesturesList = new List<string>();
        }


        public override void ChooseGestures()
        {
            Console.WriteLine("CPU will choose :");
            choice = Console.ReadLine();
        }
    }
}
