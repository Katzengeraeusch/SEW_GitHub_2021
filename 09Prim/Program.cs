using System;

namespace _09Prim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen Sie ein Programm, welches 1 positive ganze Zahl vom 
            // Benutzer einliest un dprüft, ob es sich um eine Primzahl handelt.
            // Das Ergebnis soll auf der Konsole ausgegeben werden.
            // 
            // Primzahl ist nur durch sich selbst und 1 teilbar. 
            // Kleinste Primzahl ist 2
            // 
            // Zuerst Zahl einlesen --> int
            // In einer Schleife versuchen, die Zahl zu dividieren
            // beginnend bei 2 und betrachten den Rest (modulo)
            // wenn modulo == 0, dann keine Primzahl


            Console.Write("Bitte eine positive Zahl eingeben: ");
            string input = Console.ReadLine();
            int zahl = int.Parse(input);
            // inz zahl = int.Parse(Console.ReadLine()); 

            int i = 2;
            bool isPrime = true;    // wir gehen davon aus, dass wir eine Primzahl haben,
                                    // solange wir keinen Gegenbeweis gefunden haben.
            while (i < zahl)
            {
                int rest = zahl % i;
                if (rest == 0)
                {
                    // wir haben ein i gefunden, durch welches unsere Zahl ohne Rest 
                    // dividiert werden kann
                    // definitiv keine Primzahl

                    Console.WriteLine(zahl.ToString() + " ist KEINE Primzahl");
                    isPrime = false;
                    break;
                }
                i++;
            }
            if (isPrime)
            {
                Console.WriteLine(zahl.ToString() + " ist EINE Primzahl");

            }
        }
    }
}
