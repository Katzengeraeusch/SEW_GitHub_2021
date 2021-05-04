using System;
using System.Collections.Generic;
using System.Text;

namespace _24MatheTrainer
{
    class MatheTrainerFactory
    {
        private MatheTrainer[] excercises;
        private int correctAnswers = 0;
        private int nrOfExcercises = 0;

        public MatheTrainerFactory()
        {
            // nichts zu tun
        }

        public void createTraining(int nrOfExcercises, int trainingRange)
        {
            excercises = new MatheTrainer[nrOfExcercises];
            this.nrOfExcercises = nrOfExcercises;
            for (int i = 0; i < nrOfExcercises; i++)
            {
                Random rand = new Random();
                int randValue = rand.Next(4); // Zufallszahl zw 0..3
                if (randValue == 0)
                {
                    AdditionTrainer t = new AdditionTrainer(trainingRange);
                    excercises[i] = t;
                }

                else if(randValue == 1)
                {
                    SubtractionTrainer t = new SubtractionTrainer(trainingRange);
                    excercises[i] = t;
                }

                else if (randValue == 2)
                {
                    MultiplicationTrainer t = new MultiplicationTrainer(trainingRange);
                    excercises[i] = t;
                }

                else if (randValue == 3)
                {
                    DivisionTrainer t = new DivisionTrainer(trainingRange);
                    excercises[i] = t;
                }
            }
        }

        public void train()
        {
            for (int i = 0; i < this.nrOfExcercises; i++)
            {
                Console.Write(excercises[i].excercise());
                int result = int.Parse(Console.ReadLine());

                if (result == excercises[i].getResult())
                {
                    // richtige Antwort
                    this.correctAnswers++;
                    Console.WriteLine("Richtiges Ergebnis!");
                }
                else
                {
                    // falsche Antwort
                    Console.WriteLine("Falsche Antwort! Bitte nochmals probieren!");
                    Console.Write(excercises[i].excercise());
                    result = int.Parse(Console.ReadLine());
                    // Überprüfung der 2. Antwort
                    if (result == excercises[i].getResult())
                    {
                        this.correctAnswers++;
                        Console.WriteLine("Richtiges Ergebnis!");
                    }
                    else
                    {
                        Console.WriteLine("Leider Falsch!");
                    }
                }
            }
        }

        public string getStatistics()
        {
            double percent = (double)this.correctAnswers / (double)this.nrOfExcercises * 100; //Convert to double
            return this.correctAnswers + " von " + this.nrOfExcercises + " Rechnungen (" + percent + "%) richtig gelöst";
        }

    }
}
