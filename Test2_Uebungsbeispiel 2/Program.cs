using System;

namespace Test2_Uebungsbeispiel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie eine beliebige Zahl ein: ");
            int eingabe = int.Parse(Console.ReadLine());
            string ausgabe = " ";

            for (int x = 1; x <= eingabe; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    ausgabe = ausgabe + x;
                }

                Console.WriteLine(ausgabe);
                ausgabe = " ";
            }
        }
    }
}
