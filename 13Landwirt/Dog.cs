using System;
using System.Collections.Generic;
using System.Text;

namespace _13Landwirt
{
    class Dog
    {

        //Datenkomponenten
        private string name;
        private string breed;

        //Konstruktor
        public Dog(string namein, string breedin)
        {
            this.name = namein;
            this.breed = breedin;
        }
        
        public string bark()
        {
            return "Wauauaau... WauWau!!!";
        }
        
        public string getInfo()
        {
            return "The name of the dog is: " + this.name + " the breed is: " + this.breed;
        }
        
        public string getName()
        {
            return this.name;
        }
    
    }
}
