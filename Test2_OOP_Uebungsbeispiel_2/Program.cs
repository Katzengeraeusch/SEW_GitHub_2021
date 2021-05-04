using System;

namespace Test2_OOP_Uebungsbeispiel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(0);
            
            Console.Write("Geben Sie einen Radius ein(in cm): ");
            c.Radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Die Fläche des Kreises ist " + Math.Floor(c.areameth()) + " Quadratzentinmeter und der Umfang beträgt " + Math.Floor(c.circumstancemeth()) + "cm");
        }
    }
}
