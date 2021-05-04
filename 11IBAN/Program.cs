using System;

namespace _11IBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie ein Programm zur Ermittlung eines IBANs. Es soll die KOntonummer und 
            //die Bankleitzahl eingegeben werden und der IBAN ermittelt werden.

            // 1) Kontonummer (ktnr) ung Bankleitzahl (blz) einlesen als string
        

            Console.Write("Bitte geben Sie ihre Kontonummer ein: ");
            string ktnr = Console.ReadLine();

            Console.Write("Bitte geben Sie ihre Bankleitzahl ein: ");
            string blz = Console.ReadLine();

            // 2) die Kontonummer muss 10-Stellig werden

            int length = ktnr.Length;

            // Schleife die solange eine 0 voranstellt bis die Länge 11 ist

            while(length < 11)
            {
                ktnr = "0" + ktnr;
                length++;
            }

            Console.WriteLine("Die Kontonummer ist: " + ktnr);

            string bban = blz + ktnr;

            Console.WriteLine("Ihr BBAN ist: " + bban);

            //ulong b = ulong.Parse(bban);  --> noch möglich

            string numAT = "102900";            // 1. und 20. Zeichen plus jeweils 9 und um 00 ergänzen

            string sum = bban + numAT;

            Console.WriteLine("Verbindung aus BBAN und Länderkennung: " + sum);

            //sum % 97, ulong zu klein --> overflow
            //stattdessen decimal verwenden

            decimal sumD = decimal.Parse(sum);
            
            decimal checkSumD = sumD % 97;

            int checkSum = (int)checkSumD;

            Console.WriteLine(checkSum);

            int ibanCheckSum = 98 - checkSum;

            Console.WriteLine(ibanCheckSum);

            // ibanChecksum must be 2 characters(length : 2)

            string ibanCheckSumS = ibanCheckSum.ToString();
            length = ibanCheckSumS.Length;

            if(length < 2)
            {
                ibanCheckSumS = "0" + ibanCheckSumS;

            }

            string iban = "AT" + ibanCheckSumS + bban;
            Console.WriteLine("Length: " + iban.Length);
            Console.WriteLine("IBAN" + iban.ToString());
        }
    }
}
