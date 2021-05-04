using System;

namespace _09Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstellen sie ein Programm welches eine positive ganze Zahl einliest
            //und überprüft ob es eine Primzahl ist. Das Ergebnis soll in der Konsole ausgegeben werden
            //Primzahl nur durch 1 und sich selbst teilbar
            //kleinste Primzahl

            //Zahl einlesen --> int
            // In Schleife versuchen die Zahlzu dividieren(beginnend bei 2)
            //Rest betrachten(Modulo)
            //wenn alle modulo != 0, dann ist Primzahl
            //wenn modulo == 0, dann keine Primzahl ---> Schleife abbrechen
            //Ergebnis keine Primzahl
            //am Ende der Schleife noch kein Abbruch --> Primzahl

            Console.Write("Bitte ein positive ganze Zahl eingeben: ");
            string input = Console.ReadLine();
            int zahl = int.Parse(input);
            //int zahl = int.Parse(Console.Readline()); -->option zu den oberen zwei zeilen
            int rest = 0;
            int i = 2;
            bool isPrime = true;      //gehen davon aus das wir eine Prim haben
                                      //solange wir keinen Gegenbeweis haben
            while (i < zahl)
            {
                rest = zahl % i;

                if (rest == 0)
                {
                    isPrime = false;
                }
              
                i++;
            }

            if (isPrime)
            {
                Console.WriteLine("Die Zahl ist Eine Primzahl");
            } 
            
            
            else
            {
                Console.WriteLine("Die Zahl ist Keine Primzahl");
            }





        }
    }
}
