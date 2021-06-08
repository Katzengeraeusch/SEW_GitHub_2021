using System;

namespace _01Nutztiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testprogramm für 2. Test");
            Nutztier rosi = new Kuh("Rosi", 450, 7100);
            Console.WriteLine(rosi);
            Console.WriteLine(rosi.Lieblingsfutter());


            Kuh linda = new Kuh("Linda", 570, 6900);
            Console.WriteLine(linda);
            Console.WriteLine(linda.Lieblingsfutter());
            Console.WriteLine("Milchleistung in kg: " + linda.MilchleistungInKg);
            linda.MilchleistungInKg = 7200;
            Console.WriteLine("Nach einer Kraftfutterumstellung steigt die Milchleistung auf: " + linda.MilchleistungInKg);

        }
    }
}
