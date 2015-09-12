class Euler3 {
    public static void main(String[] args)
    {
        long x = 600851475143L;
        for (long i=(long) Math.sqrt(x);i>0;i--)
        {
            if (x%i == 0 && IsPrime(i))
            {
                System.out.println(i);
                break;
            }
        }
    }
    public static Boolean IsPrime(long x)
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