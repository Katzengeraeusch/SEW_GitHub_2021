using System;
using System.Collections.Generic;
using System.Text;

namespace _15Rectangle
{
    class Rectangle
    {
        private double lenX;
        private double lenY;

        public Rectangle()
        {
            this.lenX = 0;
            this.lenY = 0;
        }

        public double LengthX
        {
            get
            {
                return this.lenX;
            }

            set
            {
                if (value >= 0)
                {
                    this.lenX = value;
                }
            }
        }
     
        public double LengthY
        {
            get
            {
                return this.lenY;
            }

            set
            {
                if (value >= 0)
                {
                    this.lenY = value;
                }
            }
        }
            public double area()
            {
                double area = this.lenX * this.lenY;
                return area;
            }

            public double circumstance()
            {
                double circumstance = 2 * lenX + 2 * lenY;
                return circumstance;
            }
    }
}
