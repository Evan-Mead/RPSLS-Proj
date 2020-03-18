using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {

        public Human(string name, string choice, int score, string gesturesList)
        {
            this.name = name;
            this.choice = choice;
            score = 0;
            this.gesturesList = new List<string>();
        }

        public override void ChooseGuestures()
        {
            Console.WriteLine("User will choose :");
            choice = Console.ReadLine();
        }


    }
}