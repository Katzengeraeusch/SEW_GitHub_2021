using System;

namespace Test2_Übungsbeispiel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie ein wie viele Würfel Sie berechnen wollen: ");
            int anzahl = int.Parse(Console.ReadLine());
            
            int zaehler = 1;

            while(zaehler <= anzahl)
            {
                int volumen = zaehler * zaehler * zaehler;
                Console.WriteLine("Das Volumen ist: " + volumen.ToString());
                zaehler++;
            }
        }
    }
}
