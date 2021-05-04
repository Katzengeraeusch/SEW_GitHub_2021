using System;
using System.Collections.Generic;
using System.Text;

namespace _22Inheritance
{
    public class Person         // public!!!
    {
        protected string firstName;         // protected --> damit Zugriff in abgeleiteter Klasse möglich ist.
        protected string lastName;

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Aufruf Konstruktor Person");
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual string getInfo()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
