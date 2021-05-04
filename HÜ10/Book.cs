using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ10
{
    class Book : Article
    {
        //Datenkomponenten
        private string isbn;
        private string author;
        private int nrOfPages;

        //Properties
        public string ISBN
        {
            get
            {
                return this.isbn;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
        }

        public int NrOfPages
        {
            get
            {
                return this.nrOfPages;
            }
        }

        //Methode
        public Book(string isbn, string author,string title, double price) : base(title, price)
        {
            this.isbn = isbn;
            this.author = author;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
