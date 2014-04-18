using System;

public class FibonacciNumber
{
    public static int FibNum(int n)
    {
        int numOne = 1;
        int numTwo = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = numOne;
            numOne = numTwo;
            numTwo = temp + numTwo;

        }
        return numOne;
    }

    public static void Main()
    {

        int num = int.Parse(Console.ReadLine());
        int fibNumber = FibNum(num);
        Console.WriteLine("The {0} Fibonacci number is {1}", num, fibNumber);

    }
}