using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Numerics;

public class Euler53
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int n = 1;
        int r = 1;
        BigInteger value = 0;
        int count = 0;
        //Console.WriteLine(Factorial(3));
        for (n = 1; n <= 100; n++)
        {
            for (r = 1; r <= n; r++)
            {
                if ((Factorial(r) * (Factorial(n - r))) != 0)
                {
                    value = (Factorial(n) / (Factorial(r) * (Factorial(n - r))));
                    // Console.WriteLine(value);
                    if (value > 1000000)
                    {
                        count++;
                    }
                }
            }
        }

        stopwatch.Stop();
        Console.WriteLine(count);
        Console.WriteLine(stopwatch.Elapsed);
        Console.Read();
    }
    static BigInteger Factorial(int x)
    {
        int i = 1;
        BigInteger result = 1;
        if (x == 0)
        {
            return 1;
        }
        for (i = x; i > 0; i--)
        {
            result *= i;
        }
        return result;
    }
}