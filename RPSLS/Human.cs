using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        public Human(string name, int score)
        {
            this.name = name;
            score = 0;
        }

        public void StareDown()
        {
            Console.WriteLine("{0} stares at opponent.", name);
        }
    }
}
