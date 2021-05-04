using System;

namespace Test2_Arrays_Uebungsbeispiel_4
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
                if (numbers[zaehler] < 0)
                {
                    numbers[zaehler] = 0;
                }
                
                //Console.WriteLine(numbers[zaehler]); //Für Kontrolle
                
                zaehler++;
            }
        }
    }
}
