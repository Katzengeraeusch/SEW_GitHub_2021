using System;
using System.Collections.Generic;
using System.Text;

namespace _24MatheTrainer
{
    class AdditionTrainer : MatheTrainer
    {
        public AdditionTrainer(int trainingRange) :base(trainingRange)
        {
            // trainingRange = 100
            // operand1 ?, operand2?
            // in einer Schleife op1 und op2 generieren und überprüfen ob < 100
            // op1 mit maximalWert 100 generieren, op2 mit maximalWert 100 - op1

            Random rand = new Random();
            this.operand1 = rand.Next(trainingRange + 1);       // weil Zufallszahl < maxValue
            this.operand2 = rand.Next(100 - this.operand1 + 1); // weil Zufallszahl < maxValue
        }

        public override string excercise()
        {
            return this.operand1.ToString() + " + " + this.operand2.ToString() + " = ";
        }

        public override int getResult()
        {
            return this.operand1 + this.operand2;
        }
    }
}
