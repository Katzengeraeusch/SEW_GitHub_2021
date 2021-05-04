using System;

namespace Saeulendiagramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte eine Zahl von 1 bis 10 eingeben: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Bitte eine Zahl von 1 bis 10 eingeben: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Bitte eine Zahl von 1 bis 10 eingeben: ");
            int c = int.Parse(Console.ReadLine());
            
            Console.Write("Bitte eine Zahl von 1 bis 10 eingeben: ");
            int d = int.Parse(Console.ReadLine());
            
            Console.Write("Bitte eine Zahl von 1 bis 10 eingeben: ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Bitte ein druckbares Zeichen eingeben: ");
            string z = Console.ReadLine();


            for (int i = 0; i < 10; i++)
            {
                string zeia = "";
                string zeib = "";
                string zeic = "";
                string zeid = "";
                string zeie = "";

                //a
                if (a >= 10 - i){
                    zeia = z;
                }

                else
                {
                    zeia = " ";
                }

                //b
                if (b >= 10 - i){
                    zeib = z;
                }

                else
                {
                    zeib = " ";
                }
                
                //c
                if (c >= 10 - i){
                    zeic = z;
                }

                else
                {
                    zeic = " ";
                }

                //d
                if (d >= 10 - i){
                    zeid = z;
                }

                else
                {
                    zeid = " ";
                }

                //e
                if (e >= 10 - i){
                    zeie = z;
                }

                else
                {
                    zeie = " ";
                }

                Console.WriteLine(" " + zeia + " " + zeib + " " + zeic + " " + zeid + " " + zeie + " ");
            }
            Console.WriteLine("__________");
            Console.WriteLine(" 1" + " 2" + " 3" + " 4" + " 5");
        }
    }
}
