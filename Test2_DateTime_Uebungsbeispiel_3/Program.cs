using System;

namespace Test2_DateTime_Uebungsbeispiel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie ein Datum ein: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            DateTime firstDay = new DateTime(date.Year, 1, 1);
            DateTime lastDay = new DateTime(date.Year, 12, 31);

            Console.WriteLine("Der erste Tag des Jahres ist ein " + firstDay.DayOfWeek + " und der letzte Tag ist ein " + lastDay.DayOfWeek);
        }
    }
}
