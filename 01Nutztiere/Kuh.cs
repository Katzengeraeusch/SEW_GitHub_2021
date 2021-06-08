using System;
using System.Collections.Generic;
using System.Text;

namespace _01Nutztiere
{
    class Kuh: Nutztier
    {
        protected int milchleistungInKg;

        public Kuh(string name, int gewicht, int milchleistung): base(name, gewicht)
        {
            this.name = name;
            this.gewichtInKg = gewicht;
            this.milchleistungInKg = milchleistung;
        }

        public int MilchleistungInKg
        {
            get
            {
                return this.milchleistungInKg;
            }

            set
            {
                this.milchleistungInKg = value;
            }
        }

        public override string Lieblingsfutter()
        {
            return "Heusilage";
        }

    }
}
