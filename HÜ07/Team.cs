using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ07
{
    class Team
    {
        //Datenkomponenten
        private string name;

        //Konstruktor
        public Team(string namein)
        {
            this.name = namein;
        }

        public string getteamName()
        {
            return this.name;
        }
     }
}
