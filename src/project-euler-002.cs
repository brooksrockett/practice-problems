using System;

public class Class1
{
	public static void Main()
	{
        int i = 1;
        int x = 0;
        int n = 0;
        int y = 0;
        while (i <= 4000000)
        {
            n= i+x;
            x=i;
            i=n;
            bool f = Convert.ToBoolean(n % 2);
            if (f == false)
            {
                y = y + n;
            }
        }
        Console.WriteLine("Sum: {0}", y);
	}
}