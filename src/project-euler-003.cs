using System;

public class Class1
{
    public static void Main()
    {
        // Given number
        long num = 600851475143;
        Console.WriteLine(num);
        // Prime check
        bool prime = true;
        // Candidate
        long x = 0;
        // Counter
        long i = 0;
        // Increase candidate by 2 until it reaches num
        for (x = 1; x <= num && x > 0; x += 2)
        {
            // Check if candidate is a factor of num
            if (num % x == 0)
            {
                // Initialize/reset prime check
                prime = true;
                // Counter 2 < i*i < x
                for (i = 3; i * i <= x; i+=2)
                {
                    // If i is a factor of x, x is not prime
                    if (x % i == 0)
                    {
                        prime = false;
                    }
                }
                // We've found a prime factor of num!
                if (prime == true)
                {
                    Console.WriteLine("Prime factor found " + x + " which multiplies by " + num / x + " to equal " + num);
                }
            }
        }
    }
}