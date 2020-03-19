using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
        }

        public void DecidingGesture()
        {
            Console.WriteLine("User is thinking...");
        }
    }
}