using System;

namespace Test2_Arrays_Uebungsbeispiel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 0, 1, 3, 5 };
            Console.WriteLine("[{0}]", string.Join("; ", num1));
            int[] num2 = { 5, 4, 5 };
            Console.WriteLine("[{0}]", string.Join("; ", num2));

            int[] num3 = new int[num1.Length + num2.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                num3[i] = num1[i];
            }
            for (int i = 0; i < num2.Length; i++)
            {
                num3[num1.Length + i] = num2[i];
            }
            Console.WriteLine("Egebnis Array" + "[{0}]", string.Join("; ", num3));




        }
    }
}
