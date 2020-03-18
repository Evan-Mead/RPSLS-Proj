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
            List<string>(gestures);
        }


        public override void ChooseGesture()
        {
            //RANDOM GESTURE
        }
    }
}
