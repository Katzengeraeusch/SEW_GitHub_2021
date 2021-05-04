using System;
using System.Collections.Generic;
using System.Text;

namespace _14MatheTrainer
{
    class Division_Trainer
    {
        private int divisor;
        private int dividend;
        private int maxValue;

        public Division_Trainer(int maxValue)
        {
            this.maxValue = maxValue;
        }

        public string exercise()
        {
            // Diese Methode erzeugt die Rechnung
            do
            {
                Random r = new Random();
                this.dividend = r.Next(0, maxValue);
                this.divisor = r.Next(1, maxValue);
            } while (dividend % divisor != 0);

            return this.dividend.ToString() + " / " + this.divisor.ToString() + " = ";
        }

        public int getResult()
        {
            //Diese Methode gibt uns das Ergebnis
            return this.dividend / this.divisor;
        }
    }
}
