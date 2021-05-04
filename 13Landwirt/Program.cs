using System;

namespace _13Landwirt
{
    class Program
    {
        static void Main(string[] args)
        {
            //definiere eine Klasse "Farmer".
            //definiere eine Klasse "Dog".
            //definiere eine Klasse "Cat".

            //Klasse Farmer
            Farmer farmer1 = new Farmer("Michael", "Haider", 16, "JohnDeere");
            Farmer farmer2 = new Farmer("Florian", "Eigner", 15, "JohnDeere");
            
            
            Console.WriteLine(farmer1.getName());
            Console.WriteLine(farmer1.getInfo());

            Console.WriteLine(farmer2.getName());
            Console.WriteLine(farmer2.getInfo());

            //Klasse "Dog"
            Dog dog1 = new Dog("Bello", "Deutscher Schäferhund");
            Dog dog2 = new Dog("Wuffi", "Westmünsterländer");

            Console.WriteLine(dog1.bark());
            Console.WriteLine(dog1.getInfo());

            Console.WriteLine(dog2.bark());
            Console.WriteLine(dog2.getInfo());

            //Klasse "Cat"
            Cat cat1 = new Cat("Minki", "Getigert");
            Cat cat2 = new Cat("Apple bzw. Apfelkatze", "Getigert mit roten Flecken");

            Console.WriteLine(cat1.Meow());
            Console.WriteLine(cat1.getInfo());

            Console.WriteLine(cat2.Meow());
            Console.WriteLine(cat2.getInfo());

            // Farmer 3
            Farmer farmer3 = new Farmer("Magdalene", "Eisner", 16, "Fendt", dog1, cat1);
            Console.WriteLine(farmer3.getInfo());
            Console.WriteLine(farmer2.getInfo());

            //Farmer 4
            Farmer farmer4 = new Farmer("Lorenz", "Forster", 15, "John Deere", dog2, null);
            Console.WriteLine(farmer4.getInfo());

            //Erweitere die Klasse Farmer um folgende Methoden:
            // nameOfDog
            //nameOfDog
            //Falls kein Hund oder keine Katze vorhanden, dann als Rückgabewert: "Leider nicht vorhanden"

            Console.WriteLine(farmer3.nameOfDog());
            Console.WriteLine(farmer3.nameOfCat());

            Console.WriteLine(farmer4.nameOfDog());
            Console.WriteLine(farmer4.nameOfCat());
        }
    }
}
