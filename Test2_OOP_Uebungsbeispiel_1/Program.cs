using System;

namespace Test2_OOP_Uebungsbeispiel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Beschleunigung ein: ");
            double beschleunigung = double.Parse(Console.ReadLine());

            Beschleunigung a = new Beschleunigung(beschleunigung);

            Console.Write("Bitte irgendeine Taste drücken für Start: ");
            string start = Console.ReadLine();
            if(start != "")
            {
                a.startmeth();
            }
            

            Console.Write("Bitte irgendeine Taste frücken für Ende: ");
            string stop = Console.ReadLine();
            if (stop != "")
            {
                a.getEndSpeed();
            }

        }
    }
}
