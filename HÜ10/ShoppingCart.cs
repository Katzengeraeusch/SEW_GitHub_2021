using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ10
{
    class ShoppingCart
    {
        //Datenkomponenten
        private Article[] articles;
        private int nrOfArticles;

        //Für Zusatz
        private int maxNrOfArticles;

        //Methoden

        public ShoppingCart(int maxNrOfArticles)
        {
            this.maxNrOfArticles = maxNrOfArticles;
            this.nrOfArticles = 0;
            this.articles = new Article[maxNrOfArticles];
        }

        public void addArticle(Article article1)
        {
            this.articles[this.nrOfArticles] = article1;
            this.nrOfArticles++;           
        }

        public void printArticles()
        {
            Console.Write("Ihre Artikel: ");
            for (int i = 0; i < this.nrOfArticles; i++)
            {
                Console.Write(articles[i].Title + "; ");
            }
        }

        public double getPriceTotal()
        {
            double priceTotal = 0;
            int i = 0;
            for (int j = 0; j < this.nrOfArticles; j++)
            {
                priceTotal = priceTotal + articles[j].Price;
                i++;
            }

            Console.WriteLine("\n");

            return priceTotal;

        }
    }
}
