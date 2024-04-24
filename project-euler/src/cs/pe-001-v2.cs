using System;

public class Euler1
{
    public static void Main()
    {
        // Here we list how many multiples of 3 and 5 are in 1000
        int multipleThree = 1000 / 3;
        int multipleFive = 1000 / 5;

        // Subtract one because 1000 is a multiple of 5 and we don't want to include that one
        multipleFive--;

        // The multiples of 15 will be used to eliminate duplicates from the multiples of 3 and 5
        int multipleFifteen = 1000 / 15;
       
        // Here we start variables for a factor counter and the sum of the factors
        int factorThree = 0;
        int factorFive = 0;
        int factorFifteen = 0;
        int sumThree = 0;
        int sumFive = 0;
        int sumFifteen = 0;

        // Count off factors until they reach the maximum number of multiples, and add each result to the sum
        while (factorThree <= multipleThree)
        {
            sumThree = sumThree + (factorThree * 3);
            factorThree++;
        }
        while (factorFive <= multipleFive)
        {
            sumFive = sumFive + (factorFive * 5);
            factorFive++;
        }
        while (factorFifteen <= multipleFifteen)
        {
            sumFifteen = sumFifteen + (factorFifteen * 15);
            factorFifteen++;
        }

        // Add the sums of the factors of 3 and 5 to get our total
        int sumTotal = sumThree + sumFive;

        // Subtract the sums of 15 from the above because we want multiples of 3 OR 5, not 3 AND 5.
        int sumFinal = sumTotal - sumFifteen;

        // Print the results
        Console.WriteLine("The sum of all multiples of 3 less than 1000 is {0}", sumThree);
        Console.WriteLine("The sum of all multiples of 5 less than 1000 is {0}", sumFive);
        Console.WriteLine("The sum of all multiples of 3 and 5 less than 1000 is {0}", sumTotal);
        Console.WriteLine("We do not want to count numbers twice because they are mutltiples of both!");
        Console.WriteLine("The sum of all multiples of 15 is {0}", sumFifteen);
        Console.WriteLine("Subtract that from our total and we find:");
        Console.WriteLine("The sum of all multiples of 3 and 5 but not 15 less than 1000 is {0}", sumFinal);

        /* I now realize I could have used one "factor" variable for all three numbers
        and one "sum" variable for 3 and 5, or one "sum" variable for all three
        and just subtracted sumFifteen instead of adding initially. Oops. */
    }
}