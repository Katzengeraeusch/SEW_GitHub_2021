using System;
using System.Collections.Generic;
using System.Text;

namespace _23GhostBusters
{
    class Ghost
    {
        protected string name;
        protected int size;

        public Ghost(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public virtual void haunt()
        {
            Console.WriteLine("Buh.......RRRRRRRRRRR");
        }

        public override string ToString()
        {
            return "Hello, my nmae is: " + this.name;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }
    }
}
