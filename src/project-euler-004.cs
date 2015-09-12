using System;
using System.Diagnostics;

public class Class1
{
	public static void Main()
	{
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        // x and y are the 3-digit numbers
        int x = 1000;
        int y = 1000;
        // a and z are the product of x and y, forwards and backwards
        string a = "a";
        string z = "";
        // n is the largest palindrome product of x and y
        int n = 0;
        // Loop until x goes from 1000 to 100
        for (x = 1000; x > 100; x--)
        {
            // Loop until y goes to 100
            for (y = 1000; y > 100; y--)
            {
                //Reset z after each loop of y
                z = "";

                // Store product of x and y in a
                a = Convert.ToString(x * y);

                /* Program errors out if trying to add the 6th character
                 * of a to z if it doesn't exist, so check for
                 * Length, then write a into z backwards */ 
                if (a.Length == 6)
                {
                    z += a[5];
                }
                z += a[4];
                z += a[3];
                z += a[2];
                z += a[1];
                z += a[0];
                /* If a and z are equal, the number is a palindrome,
                 * store it in variable n, and update n if a
                 * larger palindrome is found */
                if (a == z && Convert.ToInt32(a) > n)
                {
                    n = Convert.ToInt32(a);

                    // Clock results

                    Console.WriteLine("Time spent calculating: {0}", stopWatch.Elapsed);

                    // Write resulting variables to console
                    Console.WriteLine("X= {0}", x);
                    Console.WriteLine("Y= {0}", y);
                    Console.WriteLine("A= {0}", a);
                    Console.WriteLine("Z= {0}", z);
                }
            }
        }
    }
}
