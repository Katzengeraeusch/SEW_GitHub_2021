using System;

namespace _15Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementiere eine Klasse "Rectangle" mit den Datenkomponenten lenX und lenY.
            // Erstelle für jede Datenkomponente ein Property
            // Definiere die Methoden "area" udn "Circumstance"(Umfang)

            Rectangle r = new Rectangle();
            r.LengthX = 4.5;    //setter
            r.LengthY = 7.8;
            r.LengthX = -10.4; //setter

            Console.WriteLine("x = " + r.LengthX);
            Console.WriteLine("y = " + r.LengthY);

            Console.WriteLine("Fläche: " + r.area());
            Console.WriteLine("Umfang: " + r.circumstance());

        }
    }
}
