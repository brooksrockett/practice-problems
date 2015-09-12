using System;

class Euler1
{

    public static void Main(String[] args)
    {
        int x = 0;
        for (int i = 1; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                x += i;
            }
        }
        Console.WriteLine(x);
    }
}
