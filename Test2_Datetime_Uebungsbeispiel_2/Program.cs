using System;

namespace Test2_Datetime_Uebungsbeispiel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie ein Datum ein: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            if (date > DateTime.Now)
            {
                Console.WriteLine("Das Datum ist in der Zukunft");
            }

            if (date < DateTime.Now)
            {
                Console.WriteLine("Das Datum ist in der Vergangenheit");
            }
        }
    }
}
