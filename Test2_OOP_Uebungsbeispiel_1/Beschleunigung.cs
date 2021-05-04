using System;
using System.Collections.Generic;
using System.Text;

namespace Test2_OOP_Uebungsbeispiel_1
{
    class Beschleunigung
    {
        private DateTime start;
        private double beschleunigung;


        public Beschleunigung(double beschleunigungin)
        {
            this.beschleunigung = beschleunigungin;
        }
        public void startmeth()
        {
            this.start = DateTime.Now;
        }
        public void getEndSpeed()
        {
            Console.WriteLine("Die Endgeschwindigkeit nach " + ((DateTime.Now - this.start).TotalSeconds) + " Sekunden beträgt: " + (beschleunigung * ((DateTime.Now - this.start).TotalSeconds)).ToString() + " m/s bzw. " + (beschleunigung * ((DateTime.Now - this.start).TotalSeconds) * 3.6).ToString() + " km/h");
        }

    }
}
