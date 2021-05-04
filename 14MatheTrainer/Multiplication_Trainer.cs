using System;
using System.Collections.Generic;
using System.Text;

namespace _14MatheTrainer
{
    class Multiplication_Trainer
    {
        private int factor1;
        private int factor2;
        private int maxValue;

        public Multiplication_Trainer(int maxValue)
        {
            this.maxValue = maxValue;
        }

        public string exercise()
        {
            //Diese Methode liefert uns die Rechnung
            Random r = new Random();
            this.factor1 = r.Next(this.maxValue + 1);   // Next returns number smaller than the maxValue
            this.factor2 = r.Next(this.maxValue + 1);

            return this.factor1.ToString() + " * " + this.factor2.ToString() + " = ";
        }
        
        public int getResult()
        {
            //Liefert das Ergebnis, z.B. 20
            return this.factor1 * this.factor2;
        }
    }
}
