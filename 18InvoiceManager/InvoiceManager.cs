using System;
using System.Collections.Generic;
using System.Text;

namespace _18InvoiceManager
{
    class InvoiceManager
    {
        private Invoice[] invoices = new Invoice[1000];         //Variante 1: Direkte Initalisierung
        private string companyName;
        private int nrOfInvoices = 0;

        public InvoiceManager(string companyName)
        {
            this.companyName = companyName;
            //this.invoices = new Invoice[1000];            //Variante 2 : nachträgliche Initialisierung
        }

        public void addInvoice(Invoice invoice)
        {
            invoices[this.nrOfInvoices] = invoice;
            this.nrOfInvoices++;
        }

        public void printInvoices()
        {
            Console.WriteLine(" ");
            Console.WriteLine(this.companyName);
            Console.WriteLine("**********************************************************");

            for(int i = 0; i < this.nrOfInvoices; i++)
            {
                Invoice temp = invoices[i];
                Console.WriteLine(temp.getInfo());
            }
        }

        public void printDueDateOfInvoices() 
        {
            Console.WriteLine(" ");
            Console.WriteLine(this.companyName);
            Console.WriteLine("**********************************************************");

            for (int i = 0; i < this.nrOfInvoices; i++)
            {
                Invoice temp = invoices[i];
                Console.WriteLine(temp.getInvoiceNrAndDueDate());
            }
        }
    }
}
