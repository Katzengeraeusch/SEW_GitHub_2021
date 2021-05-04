using System;
using System.Collections.Generic;
using System.Text;

namespace _24MatheTrainer
{
    class MultiplicationTrainer:MatheTrainer
    {
        public MultiplicationTrainer(int trainingRange) : base(trainingRange)
        {
            // trainingRange = 100
            // operand1 ?, operand2?
            // in einer Schleife op1 und op2 generieren und überprüfen ob < 100
            // op1 mit maximalWert 100 generieren, op2 mit maximalWert 100 - op1

            do
            {
                Random rand = new Random();
                this.operand1 = rand.Next(trainingRange + 1);
                this.operand2 = rand.Next(trainingRange + 1);

            } while (this.getResult() > 100);
        }

        public override string excercise()
        {
            return this.operand1.ToString() + " * " + this.operand2.ToString() + " = ";
        }

        public override int getResult()
        {
            return this.operand1 * this.operand2;
        }
    }
}
