using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {

        public Human(string name, string choice, int score, string gestures)
        {
            this.name = name;
            this.choice = choice;
            score = 0;
            List<string>(gestures);
        }

        public override void ChooseGesture()
        {
            //CHOICE OF GESTURE
        }
    }
}
