using System;

namespace _08Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesen Sie com Benutzer 6  (in °C) ein. Benutzen Sie dazu eine Schleife.
            //Speichern Sie die Temperaturwerte in ein Array
            //Anschließend sollen die Temperaturwerte in K und °F umgerechnet und auf der Konsole ausgegeben werden
            //z.b.:
            //0°;273,15K; 32°F

            double[] temp = new double[6];

            //1.Schleife

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Bitte " + (i+1).ToString() + ". Temperaturwert eingeben: ");
                temp[i] = double.Parse(Console.ReadLine());
            
            }

            Console.WriteLine("                                    ");             // Leere Zeile für Layout

            //2.Schleife

            foreach (double element in temp)
            {
                string tempCelwrite = element.ToString();

                Console.WriteLine("Der Wert in Celsius ist: " + tempCelwrite + "°C");

                double tempfar = (element * 9 / 5) + 32;
                Console.WriteLine("Der Wert in Fahrenheit: " + tempfar.ToString() + "°F");

                double tempkel = element + 273.15;
                Console.WriteLine("Der Wert in Kelvin ist: " + tempkel.ToString() + "K");

                Console.WriteLine("                                    ");             // Leere Zeile für Layout

            }
        }
    }
}
