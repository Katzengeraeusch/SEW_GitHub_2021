using System;

namespace _22Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Farmer f = new Farmer("Florian", "Weigl", "AT1234567");
            Console.WriteLine(f.getInfo());

            Employee e = new Employee("Max", "Mustermann", "P123");
            Console.WriteLine(e.getInfo());

            Person p1 = f;          // Zuweisung zu einer Variable des Datentyps der Basisklasse möglich (ist-Beziehung), p1 ist vom statischen Datentyp Person und dynamisch er Datentyp Farmer
            Person p2 = e;

            Console.WriteLine(p1.getInfo());

            Console.WriteLine(f.ToString());            // Aufruf der überschriebenen Methode
            Console.WriteLine(e.ToString());            // Aufruf der Standardimplementierung der Basisklasse object

            Console.WriteLine(f.getInfo());             // Aufruf der überschriebenen Methode in Farmer
            Console.WriteLine(e.getInfo());             // Aufruf der Implementierung in der Basisklasse Person

            Console.WriteLine(p1.getInfo());            // es wird die Methode des dynamischen Datentyps aufgerufen --> Farmer
            Console.WriteLine(p2.getInfo());            // es wird die Methode des dynamischen Datentyps aufgerfuen --> Employee 
                                                        // dieser erbt die Methode von Person, überschreibt diese aber nicht

            Person[] persons = new Person[2];
            persons[0] = f;
            persons[1] = e;

            foreach(Person p in persons)
            {
                p.getInfo();
            }
        }
    }
}
