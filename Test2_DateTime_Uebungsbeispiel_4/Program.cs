using System;

namespace Test2_DateTime_Uebungsbeispiel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie ein Jahr ein: ");
            int year = int.Parse(Console.ReadLine());

            string[] firstDaysOfMonths = new string[12];
            DateTime month;
            Console.Write("[");
            for (int i = 0; i < firstDaysOfMonths.Length; i++)
            {
                month = new DateTime(year, i + 1, 1);
                firstDaysOfMonths[i] = month.DayOfWeek.ToString();
                Console.Write(firstDaysOfMonths[i] + ", ");
            }
            Console.Write("]");
            Console.WriteLine(" ");

            
        }
    }
}
