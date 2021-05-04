using System;

namespace _12FirstOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Thomas", "Riegler", "7.5.1981", "Male");
            // Datentyp: Person, Variablenname: p, Konstruktoraufruf: new Person(...
            p.sayHello();

            Person p2 = new Person("Max", "Mustermann", "1.1.2020", "Male");
            p2.sayHello();

            Person p3 = new Person("Erika", "Gabler", "1.1.2002", "Female");
            p3.setLastName("Mustermann");   //Argument "Mustermann" wird übergeben
            p3.sayHello();

            string n = p3.getLastName();

            p2.sayHelloAndBirthday();
            p2.sayNameAndSex();
            p2.sayGoodbye();

            //Erweitere die Klasse um zwei weitere Methoden
            // sayHelloAndBirthday
            // say Goodbye
            // Erweitere die Klasse um eine Datenkomponente "sex"("Male", "Female")
            // --> muss in der Konstruktor dazu
            // Noch eine Methode
            // sayNameAndSex
            // Erstellen Sie weitere Personen-Objekte udn testen Sie Ihre Methoden

            Person p4 = new Person("Diego", "Maradona", "1.1.1960", "Male");
            p4.sayNameAndSex();

            
        }
    }
}
