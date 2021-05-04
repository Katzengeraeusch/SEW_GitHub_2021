using System;

namespace HÜ05_Platztausch_im_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doublenumbers = new double[] {0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0};
            Console.WriteLine("[" + doublenumbers[0].ToString() + ";" + doublenumbers[1].ToString() + ";" + doublenumbers[2].ToString() + ";" + doublenumbers[3].ToString() + ";" + doublenumbers[4].ToString() + ";" + doublenumbers[5].ToString() + ";" + doublenumbers[6].ToString() + ";" + doublenumbers[7].ToString() + ";" + doublenumbers[8].ToString() + ";" + doublenumbers[9].ToString() + ";" + "]");
            
            for(int i =0; i<5; i++)
            {
                double zwischenspeicher = doublenumbers[i];         //Erstes Element Zwischenspeichern
                doublenumbers[i] = doublenumbers[doublenumbers.Length - i - 1];     //Erstes Element zu letztem werden lassen
                doublenumbers[doublenumbers.Length-i-1] = zwischenspeicher;     //leztes element zu erstem
                
            }

            Console.WriteLine("[" + doublenumbers[0].ToString() + ";" + doublenumbers[1].ToString() + ";" + doublenumbers[2].ToString() + ";" + doublenumbers[3].ToString() + ";" + doublenumbers[4].ToString() + ";" + doublenumbers[5].ToString() + ";" + doublenumbers[6].ToString() + ";" + doublenumbers[7].ToString() + ";" + doublenumbers[8].ToString() + ";" + doublenumbers[9].ToString() + ";" + "]");



        }
    }
}
