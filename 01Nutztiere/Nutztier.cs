using System;
using System.Collections.Generic;
using System.Text;

namespace _01Nutztiere
{
    class Nutztier
    {
        protected string name;
        protected int gewichtInKg;

        public Nutztier(string name, int gewicht)
        {
            this.name = name;
            this.gewichtInKg = gewicht;
        }

        public virtual string Lieblingsfutter()
        {
            return " ";
        }

        public override string ToString()
        {
            return "Ich bin "  + this.name + " und wiege: " + this.gewichtInKg.ToString()+ " kg.";
        }
    }
}
