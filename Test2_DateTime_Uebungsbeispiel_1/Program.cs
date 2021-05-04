using System;

namespace Test2_DateTime_Uebungsbeispiel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie ein Datum ein: ");
            DateTime time = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Der " + '"' + time.AddMonths(1).ToShortDateString() + '"' + " ist ein " + time.AddMonths(1).DayOfWeek);

           
        }
    }
}
