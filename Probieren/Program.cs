using System;

namespace Probieren
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new[] {8,4,6,2,10,0 };

            foreach (int element in Array1)
            {
                Console.WriteLine(element + 1);
            }
        }
    }
}
