using System;

namespace _01Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie ein welche Mal-Reihe ausgegeben werden soll: ");
            int malreihe = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int erg = i * malreihe;
                Console.WriteLine("Das Ergebnis von " + i.ToString() + " * " + malreihe.ToString()+" ist " + erg.ToString());
            }
        }
    }
}
