using System;
using System.Collections.Generic;
using System.Text;

namespace _12FirstOP
{
    class Person
    {
        // Datenkomponenten
        private string firstName;
        private string lastName;
        private string birthday;
        private string sex;

        // Konstruktor
        public Person(string firstName, string lastName, string birthday, string sex)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.sex = sex;
        }

        // Methoden
        public void sayHello()
        {
            Console.WriteLine("Hello I am : " + this.firstName + " " + this.lastName);
        }

        public void setLastName(string lastName) 
        {
            //ev. zusätzlicher Code
            this.lastName = lastName;
                
        }

        public string getLastName()
        {
            return this.lastName;
        }
        
        public void sayHelloAndBirthday()
        {
            Console.WriteLine("Hello, I am " + this.firstName + " " + this.lastName + " and I am born on the " + this.birthday);
        }

        public void sayGoodbye()
        {
            Console.WriteLine(this.firstName + " wishes you a good day");
        }

        public void sayNameAndSex()
        {
            Console.WriteLine("My name is " + this.firstName + " "+ this.lastName+" and I am " + this.sex);
        }

       

    }
}
