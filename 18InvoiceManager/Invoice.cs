using System;
using System.Collections.Generic;
using System.Text;

namespace _18InvoiceManager
{
    class Invoice
    {
        private string invoiceNr;
        private double amount;
        private DateTime invoiceDate;
        private DateTime dueDate;

        public Invoice(string invoiceNr, double amount, DateTime invoiceDate, int timetoPay)
        {
            this.invoiceNr = invoiceNr;
            this.amount = amount;
            this.invoiceDate = invoiceDate;
            this.dueDate = invoiceDate.AddDays(timetoPay);
        }

        public string getInfo()         //alle Rechnungsdaten
        {
            return "Rechnungsnummer: " + this.invoiceNr + ", zu bezahlender Betrag: " + amount.ToString() + "€" + ", Rechnungsdatum: " + invoiceDate.ToShortDateString() + ", Letztes Bezahldatum " + dueDate.ToShortDateString();
           
        }

        public string getInvoiceNrAndDueDate()
        {
            return "Rechnungsnr. : " + this.invoiceNr + ", Letztes Bezahldatum " + dueDate.ToShortDateString();
        }
    }
}
