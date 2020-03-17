using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class AI : Player
    {
        public AI(string name, int score)
        {
            this.name = name;
            score = 0;
        }

        public void Computing()
        {
            Console.WriteLine("{0} computes next move.", name);
        }
    }
}
