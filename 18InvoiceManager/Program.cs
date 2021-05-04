using System;

namespace _18InvoiceManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv1 = new Invoice("R1234", 19.90, DateTime.Now, 21);
            Invoice inv2 = new Invoice("R5678", 80.90, new DateTime(2021, 2, 15) , 30);
            DateTime date = new DateTime(2021, 2, 14);
            Invoice inv3 = new Invoice("R1000", 27.90, date, 8);

            Console.WriteLine(inv1.getInfo());
            Console.WriteLine(inv2.getInvoiceNrAndDueDate());

            InvoiceManager manager = new InvoiceManager("Umbrella Corp.");
            manager.addInvoice(inv1);
            manager.addInvoice(inv2); 
            manager.addInvoice(inv3);

            manager.printInvoices();
            manager.printDueDateOfInvoices();
        }
    }
}
