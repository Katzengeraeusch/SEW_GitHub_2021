using System;
using System.Collections.Generic;
using System.Text;

namespace _22Inheritance
{
    class Employee : Person
    {
        private string personalNr;

        public Employee(string firstName, string lastName, string personalNr) : base(firstName, lastName)
        {
            Console.WriteLine("Aufruf Konstruktor Employee");           // Ausgabe im Konstruktor nur in diesem Fall für Lernzwecke (Demozwecke)
            this.personalNr = personalNr;
        }


    }
}
