using System;

public class PrimeChecker
{
    public static bool IsPrime(int number)
    {
        
    if (number==1)
        {
    	    return false;
        }
    if (number % 2 == 0)
    {
        if (number == 2)
        {
            return true;
        }
        return false;
    }
    
    int max = (int)Math.Sqrt(number);
    for (int i = 3; i <= max; i += 2)
    {
        if ((number % i) == 0)
        {
            return false;
        }
    }
    return true;

    }
    public static void Main()
    {

        int num = int.Parse(Console.ReadLine());
        bool primecheck = IsPrime(num);
        Console.WriteLine("{0} - {1}", num, primecheck);

    }
}