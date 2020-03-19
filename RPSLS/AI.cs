using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class AI : Player
    {
        public AI(string name)
        {
            this.name = name;
        }

        public void DecidingGesture()
        {
            Console.WriteLine("CPU is running schematics...");
        }
    }
}
