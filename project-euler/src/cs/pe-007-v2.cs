using System;
using System.Diagnostics;
using System.Collections.Generic;

public class Euler7
{
    public static void Main()
    {
        // Start timer
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        // Init list primes to hold prime numbers found
        List<int> primes = new List<int>();
        // Add 2 (initial prime) to list
        primes.Add(2);
        // Init y (number to test), n (counter), x (prime to divide by), z (false if no divisors found)
        int y = 3;
        int n = 0;
        int x = primes[n];
        bool z = false;
        // Loop until the 10001st prime is found
        while (primes.Count < 10001)
        {
            // Start n at 0, counting up by one until reaching the end of list primes or until x reaches half of y
            for (n = 0; (n < primes.Count) && (x < y / 2); n++)
            {
                x = primes[n];
                // Set z true if y has a divisor between 1 and itself (indicating not prime)
                if (y % x == 0)
                {
                    z = true;
                }
            }
            // If no divisors found, add y to list of primes
            if (z == false)
            {
                primes.Add(y);
            }
            // Reset vars, change y to next odd number (no even primes after 2) and return to loop
            z = false;
            y = y + 2;
            n = 0;
            x = primes[n];

        }
        // Stop timer and display results
        stopWatch.Stop();
        Console.WriteLine("10,001st prime is {0}", primes[10000]);
        Console.WriteLine("Time spent calculating: {0}", stopWatch.Elapsed);
    }
}
