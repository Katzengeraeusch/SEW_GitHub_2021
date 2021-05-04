using System;

namespace Test2_Uebungsbeispiel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine Zahl ein: ");
            int zahlein = int.Parse(Console.ReadLine());

            if (zahlein % 2 == 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch die einstellige Zahl 2 ohne Rest teilbar.");
            }

            if (zahlein % 3 == 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch die einstellige Zahl 3 ohne Rest teilbar.");
            }
            if (zahlein % 4 == 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch die einstellige Zahl 4 ohne Rest teilbar.");
            }
            if (zahlein % 5 == 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch die einstellige Zahl 5 ohne Rest teilbar.");
            }
            if (zahlein % 6 == 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch die einstellige Zahl 6 ohne Rest teilbar.");
            }
            if (zahlein % 7 == 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch die einstellige Zahl 7 ohne Rest teilbar.");
            }
            if (zahlein % 8 == 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch die einstellige Zahl 8 ohne Rest teilbar.");
            }
            if (zahlein % 9 == 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch die einstellige Zahl 9 ohne Rest teilbar.");
            }

            if(zahlein % 2 != 0 && zahlein % 3 != 0  && zahlein % 4 != 0 && zahlein % 5 != 0 && zahlein % 6 != 0 && zahlein % 7 != 0 && zahlein % 8 != 0  && zahlein % 9 != 0)
            {
                Console.WriteLine("Die Zahl " + zahlein.ToString() + " ist durch keine einstellige Zahl größer 1 ohne Rest teilbar.");
            }



        }
    }
}
