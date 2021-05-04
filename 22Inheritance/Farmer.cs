using System;
using System.Collections.Generic;
using System.Text;

namespace _22Inheritance
{
    public class Farmer : Person       // public!!,  Erben von der Basisklasse Person
    {
        private string lfbisNr;

        public Farmer(string firstName, string lastName, string lfbisNr) : base(firstName, lastName)
                                                                            // Rufe den Konstruktor der Basisklasse auf
        {
            Console.WriteLine("Aufruf Konstruktor Farmer");
            this.lfbisNr = lfbisNr;
            // an dieser Stelle sind alle 3 Datenkomponenten intialisiert

            // Zugriff auf this.lastName an dieser Stelle möglich!
            this.firstName = "Diplomfarmer";
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " - " + this.lfbisNr;
        }

        public override string getInfo()
        {
            return "Hallo ich bin Farmer: " + this.lastName;
        }


    }
}
