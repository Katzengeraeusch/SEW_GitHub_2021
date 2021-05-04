using System;

namespace Zahlenkonvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine dezimale Zahl (von 0 bis 255) ein die Sie in eine Dualzahl umwandeln wollen: ");
            int inp = int.Parse(Console.ReadLine());
           
            string aus = "0";
            string endaus = "";
            int modulo = 0;
            int weiterrech = 1;
         
            while (weiterrech != 0)
            {
                modulo = inp % 2;
                weiterrech = inp / 2;
                inp=weiterrech;

                if (modulo == 0)
                {
                    aus = "0";
                }

                else
                {
                    aus = "1";
                }

                endaus = aus + endaus;
            }

            Console.WriteLine("Die Zahl in Binär ist: " + endaus);

            

            

        }
    }
}
