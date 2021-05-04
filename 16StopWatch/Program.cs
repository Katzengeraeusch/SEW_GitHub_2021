using System;

namespace _16StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch watch = new StopWatch();  // watch starts
            TimeSpan span = watch.elapsed();    // watch runs

            Console.WriteLine(span);

            int limit = 1000000000;
            StopWatch watch1 = new StopWatch();
            double sum1 = 0;
            for(int i = 0; i < limit; i++)
            {
                sum1 += i * i;
            }

            Console.WriteLine("Elapsed: " + watch1.elapsed());
            
            StopWatch watch2 = new StopWatch();
            long sum2 = 0;
            for(int i = 0; i<limit; i++)
            {
                sum2 += i * i;
            }

            Console.WriteLine("Elapsed: " + watch2.elapsed());
        }
    }
}
