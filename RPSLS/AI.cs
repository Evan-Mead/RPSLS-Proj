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

        public void DecidingGuesture()
        {
            Console.WriteLine("CPU is running schematics...");
        }
    }
}
