using System;
using System.Collections.Generic;
using System.Text;

namespace _13Landwirt
{
    class Farmer
    {
        //Datenkomponenten
        private string firstName;
        private string lastName;
        private int age;
        private string favtractor;
        private Dog myDog;
        private Cat myCat;

        //Konstruktor
        public Farmer(string firstNamein, string lastNamein, int agein, string favtractorin)
        {
            this.firstName = firstNamein;
            this.lastName = lastNamein;
            this.age = agein;
            this.favtractor = favtractorin;
            this.myDog = null;
            this.myCat = null;
        }

        //2. Konstruktor
        public Farmer (string firstNamein, string lastNamein, int agein, string favtractorin, Dog dog, Cat cat)
        {
            this.firstName = firstNamein;
            this.lastName = lastNamein;
            this.age = agein;
            this.favtractor = favtractorin;
            this.myDog = dog;
            this.myCat = cat;
        }

        public string getName()
        {
            return this.firstName + " " + this.lastName;
        }   

        public string getInfo()
        {
            //return this.getName() + ", age: " + this.age + ", tractor: " + this.favtractor;
            //call method of this class
            string ret = this.getName() + ", age: " + this.age + ", tractor: " + this.favtractor;
            if (this.myDog != null)
            {
                //farmer has a dog
                ret = ret + " ,dog: " + this.myDog.getInfo();
            }

            if (this.myCat != null)
            {
                //farmer has a cat
                ret = ret + " ,cat: " + this.myCat.getInfo();
            }
            return ret;
        }

        public string nameOfDog()
        {
            if(this.myDog == null)
            {
                return "Leider kein Hund vorhanden.";
            }
            return this.myDog.getName();
            
        }

        public string nameOfCat()
        {
            if (this.myCat == null)
            {
                return "Leider keine Katze vorhanden.";
            }
            return this.myCat.getName();

        }

    }
}
