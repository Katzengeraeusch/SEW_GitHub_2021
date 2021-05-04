using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ10
{
    class Stream:Article
    {
        //Datenkomponenten
        private int length;
        private DateTime availabilityDue;

        //Properties
        public int Length
        {
            get
            {
                return this.length;
            }
        }

        public DateTime AvailibilityDue
        {
            get
            {
                return this.availabilityDue;
            }
        }

        //Methoden
        public Stream(int length, DateTime availibilityDueIn, string title, double price) : base(title, price)
        {
            this.availabilityDue = availibilityDueIn;
            this.length = length;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
