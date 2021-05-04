using System;

namespace HÜ06
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI_Rechner p1 = new BMI_Rechner("Max", "Mustermann", 75, 1.80);
            Console.WriteLine(p1.getBMI());
            Console.WriteLine(p1.getGewichtsKlasse());

            Console.WriteLine("-------------");

            BMI_Rechner p2 = new BMI_Rechner("Frau", "Mustermann", 60, 1.65);
            Console.WriteLine(p2.getBMI());
            Console.WriteLine(p2.getGewichtsKlasse());
        }
    }
}
