using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ06
{
    class BMI_Rechner
    {
        //Datenkomponenten
        private string firstname;
        private string lastname;
        private double weight;
        private double height;
        private double BMI;
    
        //Konstruktor
        public BMI_Rechner(string vorname, string lastname, double weight, double height)
        {
            this.firstname = vorname;
            this.lastname = lastname;
            this.weight = weight;
            this.height = height;
        }

        //Methoden
        public double getBMI()
        {
            this.BMI = this.weight / (this.height * this.height);
            return this.BMI;
        }

        public string getGewichtsKlasse()
        {

            if (this.BMI < 18.5)
            {
                return "Du bist untergewichtet";
            }

            if(this.BMI>= 18.5 && this.BMI < 25)
            {
                return "Du bist normalgewichtig";
            }

            if (this.BMI >= 25 && this.BMI < 30)
            {
                return "Du bist übergewichtig";
            }

            if (this.BMI >= 30)
            {
                return "Du bist fettleibig";
            }

            else
            {
                return "";
            }
        }
    }
}
