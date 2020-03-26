using System;

public class Class1
{
	public static void Main()
	{
        // Given number
        long num = 2000000;
        // Prime check
        bool prime = true;
        // Candidate
        long x = 0;
        // Counter
        long i = 0;
        // Sum
        long sum = 2;
        // Increase candidate by 2 until it reaches num
        for (x = 3; x < num; x = x + 2)
        {
            // Counter 2 < i < x
            for (i = 2; i*i <= x; i++)
            {
                // If i is a factor of x, x is not prime
                if (x % i == 0)
                {
                    prime = false;
                }
            }
            // We've found a prime!
            if (prime == true)
            {
                sum = sum + x;
                
            }
            prime = true;
        }
        Console.WriteLine("The sum of all primes below 2 million is " + sum);
	}
}
