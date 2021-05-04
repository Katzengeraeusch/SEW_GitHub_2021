using System;

namespace _14MatheTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie viele Rechnungen möchtest du trainieren?: ");
            int nrOfExercises = int.Parse(Console.ReadLine());

            for (int i = 0; i < nrOfExercises; i++)
            {
                Multiplication_Trainer trainer = new Multiplication_Trainer(10);
                Console.Write(trainer.exercise());
                string result = Console.ReadLine();
                if (int.Parse(result) == trainer.getResult())
                {
                    Console.WriteLine("Richtig");
                }
                else
                {
                    Console.WriteLine("Leider Falsch, richtige Antwort: " + trainer.getResult());
                }
                Console.WriteLine("              ");
            }   
                //Erstelle einen DivisionsTrainer
                //Zusatz: das Ergebnis der Division soll ganzzahlig sein
                // Wenn keine ganzzahlige Division (Modulo nicht 0), dann neue Rechnung
                
                Console.Write("Wie viele Rechnungen möchtest du trainieren?: ");
                int nrOfExercises_division = int.Parse(Console.ReadLine());

                for (int j = 0; j < nrOfExercises_division; j++)
                {
                    Division_Trainer trainer_division = new Division_Trainer(10);
                    Console.Write(trainer_division.exercise());
                    string result_division = Console.ReadLine();
                    if (int.Parse(result_division) == trainer_division.getResult())
                    {
                        Console.WriteLine("Richtig");
                    }
                    else
                    {
                        Console.WriteLine("Leider Falsch, richtige Antwort: " + trainer_division.getResult());
                    }
                    Console.WriteLine("              ");
                }

            
        }
    }
}
