using System;

namespace _10Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // ERstellen sie ein Programm welches die Fibonacci Zahlen berechnet und ausgibt.
            // Der Benutzer soll eingeben wieviele Fibonacci berechnet werden sollen.

            //Fib(0) = 0
            //Fib(1) = 1
            //Fib(2) = Fib(1) + Fib(0)      --> 1
            //Fib(3) = Fib(2) + Fib(1) + Fib(0) --> 2
            //Fib(4) = Fib(3) + Fib(2) + Fib(1) + Fib(0) --> 3

            // 1) Vom Benutzer Zahl einlesen
            // 2) Schleife (For-Schleife)
            // 3) 2 Variablen die jeweils aktualisiert werden und zusätzlich eine Hilfsvariable

            Console.Write("Wie viele Fibonacci Zahlen sollen ausgegeben werden(größer zwei): ");
            int anzahl  = int.Parse(Console.ReadLine());
            int fib0 = 0;
            int fib1 = 1;
            Console.WriteLine("Fib(0) = 0");
            Console.WriteLine("Fib(1) = 1");
            for (int i = 2; i < anzahl; i++)
            {
                int fibAus = fib1 + fib0;
                Console.WriteLine("Fib(" + i.ToString() + ") = " + fibAus.ToString());
                fib0 = fib1;
                fib1 = fibAus;
            }
            
        }
    }
}
