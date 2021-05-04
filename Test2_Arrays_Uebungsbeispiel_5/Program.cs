using System;

namespace Test2_Arrays_Uebungsbeispiel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new[] { 1000, 200, 0, 30, 40, 0, 0 };

            int lenArray = Array.Length;
            int zaehler = 0;

            while (zaehler < lenArray)
            {
                if(Array[zaehler] == 0)
                {
                    Console.WriteLine("Die Zahl an der Stelle " + zaehler + " ist null");
                }
                zaehler++;
            }
        }
    }
}
