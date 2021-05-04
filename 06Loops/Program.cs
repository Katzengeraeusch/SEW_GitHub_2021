using System;

namespace _06Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

            int j = 0;
            int sum2 = 0;
            while (j < 5)
            {
                sum2 += numbers[j];
                j++;
            }
            Console.WriteLine(sum2);

            int sum3 = 0;
            foreach(int element in numbers)
            {
                sum3 += element;
            }
            Console.WriteLine(sum3);

            int k = 0;
            int sum4 = 0;
            do
            {
                sum4 += numbers[k];
                k++;
            } while (k < 5);
            Console.WriteLine(sum4);
            

           }
    }
}
