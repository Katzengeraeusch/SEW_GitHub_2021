using System;
using System.Collections.Generic;
using System.Text;

namespace _24MatheTrainer
{
    class MatheTrainer
    {
        protected int operand1;
        protected int operand2;

        public MatheTrainer(int trainingRange)
        {

        }

        public virtual string excercise()
        {
            return "";      // return Leerstring --> wird überschrieben
        }

        public virtual int getResult()
        {
            return 0;      // return 0 --> wird überschrieben
        }
    }
}
