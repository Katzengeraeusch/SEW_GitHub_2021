using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ10
{
    class EBook:Article
    {
        //Datenkomponenten
        private string isbn;
        private string format;
        private string author;
        
        //Properties
        public string ISBN
        {
            get
            {
                return this.isbn;
            }
        }

        public string Format
        {
            get
            {
                return this.format;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
        }

        //Methoden
        public EBook(string isbn, string format, string author, double price, string title) : base(title,price)
        {
            this.isbn = isbn;
            this.format = format;
            this.author = author;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
