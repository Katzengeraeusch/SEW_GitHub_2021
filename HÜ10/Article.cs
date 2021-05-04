using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ10
{
    class Article
    {
        //Datenkomponenten
        protected string description;
        protected double price;
        protected string title;

        //Properties
        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
        }

        //Methoden

        public Article(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
