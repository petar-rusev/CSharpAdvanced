using System;
using System.Collections.Generic;
//This is program for sorting some numbers
class SortingNumbers
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int [] array=new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort<int>(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }


    }
}

