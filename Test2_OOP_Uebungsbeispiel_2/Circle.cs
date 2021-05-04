using System;
using System.Collections.Generic;
using System.Text;

namespace Test2_OOP_Uebungsbeispiel_2
{
    class Circle
    {
        private double radius;

        public Circle(double radiusin)
        {
            this.radius = radiusin;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                this.radius = value;
            }
        }

        public double areameth()
        {
            double area = (this.radius * this.radius) * Math.PI;
            return area;
        }
        public double circumstancemeth()
        {
            double circumstance = this.radius * 2 * Math.PI;
            return circumstance;
        }

    }
}
