using System;
using System.Collections.Generic;
using System.Text;

namespace _13Landwirt
{
    class Cat
    {
        //Datenkomponenten
        private string name;
        private string color;

        //Konstruktor
        public Cat(string namein, string colorin)
        {
            this.name = namein;
            this.color = colorin;
        }

        //Methoden
        public string Meow()
        {
            return "Meow?!";
        }

        public string getInfo()
        {
            return "The name of the cat is: " + this.name + ", the color of the cat is: " + color;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
