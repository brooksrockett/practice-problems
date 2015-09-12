using System;

class Euler3
{
    public static void Main()
	{
        long x = 600851475143;
        for (long i=Convert.ToInt64(Math.Sqrt(x));i>0;i--)
        {
            if (x%i == 0 && IsPrime(i))
            {
        		Console.WriteLine(i);
				break;
            }
        }
	}
    public static bool IsPrime(long x)
    {
            for (int i = 3; i*i < x; i+=2)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
		return true;
    }
        
}
