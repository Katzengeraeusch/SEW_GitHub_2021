using System;
using System.Collections.Generic;
using System.Text;

namespace _23GhostBusters
{
    class CannibalGhost : Ghost
    {
        private Ghost[] eatenGhosts = new Ghost[10];
        private int nrOfEatenGhosts = 0;

        public CannibalGhost(string name):base(name, 1)
        {
            // alles initialisiert
        }

        public void eat(Ghost ghost)
        {
            if(this.nrOfEatenGhosts == 10)
            {
                // Geist explodiert wenn > 10 Geister verspeist
                Console.WriteLine("Boooom..." + this.name + " exploded!");
                return;
            }
            
            this.eatenGhosts[nrOfEatenGhosts] = ghost;
            this.nrOfEatenGhosts++;
            this.size += ghost.Size;
        }

        public override void haunt()
        {
            base.haunt();
        }

    }
}
