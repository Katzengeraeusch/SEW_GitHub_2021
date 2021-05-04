using System;
using System.Collections.Generic;
using System.Text;

namespace _23GhostBusters
{
    class NoicyGhost : Ghost
    {
        //keine weiteren Datenkomponenten

        public NoicyGhost(string name): base(name, 0)
        {
            // keine Arbeit zu  erledigen
        }

        public override void haunt()
        {
            Console.WriteLine("Pooooooooooooooooooh.....Pooooh............Pooooooooooooooooooooooooooooooooooooooooooooooooooooooooo! RRRRRRRRRRRRRRRRRRR");
        }
    }
}
