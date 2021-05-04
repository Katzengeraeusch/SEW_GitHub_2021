using System;
using System.Collections.Generic;
using System.Text;

namespace _23GhostBusters
{
    class SlimeGhost : Ghost
    {
        private string color;

        public SlimeGhost(string name, string color) : base(name, 1)
        {
            this.color = color;
        }

        public override void haunt()
        {
            Console.WriteLine(this.name + " leaves " + this.color + " slime!" + "                 RRrrrr!");
        }


    }
}
