using System;

namespace _24MatheTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            MatheTrainerFactory factory = new MatheTrainerFactory();
            factory.createTraining(5, 100);
            factory.train();
        }
    }
}
