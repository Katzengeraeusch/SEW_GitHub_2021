using System;
using System.Collections.Generic;
using System.Text;

namespace _02Test
{
    class Tractor
    {
        private string brand;
        private string type;
        private double power;

        public Tractor(string brandin, string typein, double powerin)
        {
            this.brand = brandin;
            this.type = typein;
            this.power = powerin;
        }

        public double  Power
        {
            get
            {
                return this.power;
            }

            set
            {                               
                this.power = value;
            }
        }

        public double getPowerInHP()
        {
            double PowerInHP = this.power * 1.36;
            return PowerInHP;
        }

    }
}
