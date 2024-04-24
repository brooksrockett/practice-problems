using System;

public class Euler11
{
    public static void Main()
    {
        int i = 1;
        int y = 1;
        int tri = 0;
        int x = 0;
        int root;
        for (i=1;x<=500;i++)
        {
            tri += i;
            x = 0;
            root = (int) Math.Sqrt(tri);
            if (tri % 2 == 0)
            {
                for (y = 1; y < root; y++)
                {
                    if (tri % y == 0)
                    {
                        x+=2;
                    }
                }
            }
            else
            {
                for (y = 1; y < root; y+=2)
                {
                    if (tri % y == 0)
                    {
                        x+=2;
                    }
                }
            }
        }
        Console.WriteLine("\nTriangle #: " + (i) + " Divisors: " + x);
        Console.WriteLine("\nAnswer value: " + tri);
    }
}