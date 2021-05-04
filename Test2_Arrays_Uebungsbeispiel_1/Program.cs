using System;

namespace Test2_Arrays_Uebungsbeispiel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie ein wie viele Würfel Sie berechnen wollen: ");
            int anzahl = int.Parse(Console.ReadLine());

            int zaehler = 0;

            int[] volumenarray = new int[anzahl];

            while (zaehler <= anzahl)
            {
                int volumen = zaehler * zaehler * zaehler;
                volumenarray[zaehler] = volumen;
                Console.WriteLine("volumen[" + zaehler + "] = " + volumenarray[zaehler]);
                zaehler++;
            }
        }
    }
}
