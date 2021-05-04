using System;

namespace _02Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tractor t1 = new Tractor("Steyr", "975", 75);
            t1.Power = 70;
            Console.WriteLine("Die Leistung in PS beträgt: " + t1.getPowerInHP().ToString());

            Tractor t2 = new Tractor("John Deere", "5100", 100);
            t2.Power = 95;
            Console.WriteLine("Die Leistung in PS beträgt: " + t2.getPowerInHP().ToString());

            Tractor t3 = new Tractor("Valtra", "G135", 135);
            t3.Power = 125;
            Console.WriteLine("Die Leistung in PS beträgt: " + t3.getPowerInHP().ToString());
        }
    }
}
