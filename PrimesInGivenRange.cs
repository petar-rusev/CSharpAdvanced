using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    public static bool IsPrime(int number)
    {

        if (number == 1)
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
		int startNum=int.Parse(Console.ReadLine());
		int endNum=int.Parse(Console.ReadLine());
        if (startNum > endNum)
        {
            Console.WriteLine("empty list");
        }
		List<int> primes = new List<int>();
		
		for(int i=startNum;i<=endNum;i++)
		{
			if(IsPrime(i)==true)
			{
				primes.Add(i);
			}
		}
		
		foreach(int a in primes)
		{
			
			Console.Write("{0} ",a);
		}
    }
}

