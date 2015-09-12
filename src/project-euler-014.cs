using System;

public class Euler14
{
    public static void Main()
    {
        int i;
        long n;
        int count = 0;
        int longest = 0;
        int final = 0;
        for (i = 1000000; i > 1; i--)
        {
            n = (long) i;
            while (n > 1)
            {
            if (n % 2 == 0)
            {
                n = n/2;
                count++;
            }
            else
            {
                n = (3*n)+1;
                count++;
            }
            }
            if (count >= longest)
            {
                longest = count+1;
                final = i;
            }
            count = 0;
        }
        Console.WriteLine("Final number: " + final + " Chain: "  + longest);
    }
}
