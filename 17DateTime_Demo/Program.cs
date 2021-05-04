
using System;

namespace _17DateTime_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            // Einfache Uhrzeit
            Console.WriteLine(dt.ToShortTimeString());
            // Datum ausgeschrieben mit wochentag
            Console.WriteLine(dt.ToLongDateString());
            // Uhrzeit mit Sekunden
            Console.WriteLine(dt.ToLongTimeString());
            // Jahr
            Console.WriteLine("Jahr: " + dt.Year);
            // Monat
            Console.WriteLine("Monat: " + dt.Month);
            // Tag
            Console.WriteLine("Tag: " + dt.Day);
            // Stunde
            Console.WriteLine("Stunde: " + dt.Hour);
            // Minute
            Console.WriteLine("Minute: " + dt.Minute);
            // Sekunde
            Console.WriteLine("Sekunde: " + dt.Second);
            // Millisekunde
            Console.WriteLine("Millisekunde: " + dt.Millisecond);
            // Wochentag
            Console.WriteLine("Wochentag: " + dt.DayOfWeek);

            DateTime myBirthday = new DateTime(2004, 11, 7);
            Console.WriteLine("Mein Geburtstag: " + myBirthday.ToLongDateString());

            // Wochentag meines Geburtstages
            Console.WriteLine("Wochentag meines Geburtstages: " + myBirthday.DayOfWeek);

            // Mein Alter in Tagen
            TimeSpan span = dt - myBirthday;
            Console.WriteLine("Alter in Tagen: " + span.Days);

            // Alter in Sekunden
            Console.WriteLine("Alter in Sekunden: " + span.TotalSeconds);

            //Tag bis Ferien
            DateTime holidayStart = new DateTime(2021, 7, 3);
            TimeSpan tillHolidays = holidayStart - dt;
            Console.WriteLine("Tage bis Ferienstart: " + tillHolidays.Days);


            
        }
    }
}
