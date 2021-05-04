using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ10
{
    class DVD : Article
    {
        //Datenkomponenten
        private int length;

        //Properties
        public int Length
        {
            get
            {
                return this.length;
            }
        }

        //Methoden
        public DVD(int length, string title, double price) : base(title, price)
        {
            this.length = length;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
