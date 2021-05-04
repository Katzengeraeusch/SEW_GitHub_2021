using System;

namespace HÜ10
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart SC = new ShoppingCart(100);
        
            Article book1 = new Book("1234", "Irgendwer","Ein Titel", 420.69 );
            Article ebook1 = new EBook("1234","PDF", "Irgendwer",420.69, "Ein elektrisches Buch");
            Article dvd1 = new DVD(69, "Weed for Speed", 420);
            Article stream1 = new Stream(420, new DateTime(4200, 12, 12),"Eine Serie", 69);
            Article book2 = new Book("1234", "Irgendwer2", "Ein Buch", 420.69);


            SC.addArticle(book1);
            SC.addArticle(ebook1);
            SC.addArticle(dvd1);
            SC.addArticle(stream1);
            SC.addArticle(book2);

            SC.printArticles();

            Console.WriteLine("Der Gesamte Preis: " + SC.getPriceTotal() + " Euro");
        }
    }
}
