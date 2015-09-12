using System;
using System.Numerics;
using System.Diagnostics;

public class Euler97
{
	public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int first = 28433;
            BigInteger sum = new BigInteger();
            sum = 2;
            long i;
            for (i = 1; i < 7830457; i++)
            {
                sum *= 2;
                while (sum >= 100000000000)
                {
                    sum = sum % 100000000000;
                }
            }
            BigInteger total = ((first * sum) + 1) % 10000000000;
            stopwatch.Stop();
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Time: " + stopwatch.Elapsed);
            Console.Read();
        }
}