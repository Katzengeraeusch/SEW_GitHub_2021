using System;

namespace _07Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];             // Container for 5 int (leeres Array), Standardinitialisierung mit 0
            int[] moreNumbers = new int[] { 1, 2, 3, 4 };           // Container für 4 int, die bereits initialisiert wurden
            int[] emptyArray;                                       // Deklaration für ein Array mit int

            emptyArray = new int[2];                                // Wertzuweisung eines leeren Array

            Console.WriteLine(numbers[0]);                          // Zugriff auf das Element mit Index 0 (1. Element)
            Console.WriteLine(moreNumbers[2]);

            numbers[0] = 100;                                       // Überschreiben des Wertes an Index 0
            numbers[0] = 200;
            numbers[1] = 300;

            // Erstellen Sie ein Array mit den Zahlen {1, 100, 1000, 10000, 100000}. Addieren Sie die Zahlen
            // (keine Schleife benutzen) und geben Sie das Ergebnis auf der Konsole aus.

            int[] ar = new int[] { 1, 100, 1000, 10000, 100000 };
            int ausgabe = ar[0] + ar[1] + ar[2] + ar[3] + ar[4];
            Console.WriteLine(ausgabe.ToString());

            // Erstellen Sie ein Array mit den Zahlen {1.1, 2.0, 3.4, 4.5, 6.7} Multiplizieren sie diese Zahlen und 
            //geben Sie das Ergebnis auf der Konsole aus.
            float[] a = new float[] { 1.1f, 2.0f, 3.4f, 4.5f, 6.7f };       // für Werte des Datentyps float ein "f" anhängen
            float ausgabe1 = a[0] * a[1] * a[2] * a[3] * a[4];
            Console.WriteLine(ausgabe1.ToString());

        }
    }
}
