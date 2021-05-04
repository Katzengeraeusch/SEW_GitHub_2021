using System;

namespace Test2_Arrays_Uebungsbeispiele_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { -1, 2, 3, 4, 5 };

            int lennumbers = numbers.Length;
            int zaehler = 0;

            while (zaehler < lennumbers)
            {
                if(numbers[zaehler] < 0)
                {
                    Console.WriteLine("Die Zahl im Array Numbers an der Stelle " + zaehler + " ist kleiner null");
                }
                zaehler++;
            }
        }
    }
}
