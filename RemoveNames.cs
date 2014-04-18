using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{   //Method for filling the Lists.
    private static List<string> Filler(string firstList)
    {
        List<string> listOne = new List<string>();
        char delimiter = ' ';
        string[] wordsOne = firstList.Split(delimiter);
        for (int i = 0; i < wordsOne.Length; i++)
        {
            listOne.Add(wordsOne[i]);
        }

        return listOne;
    }
    
    static void Main()
    {
        string firstList = Console.ReadLine();
        string secondList = Console.ReadLine();

        List<string> one = Filler(firstList);
        List<string> two = Filler(secondList);
        List<string> result =new List<string>();

       
            for (int i = 0; i < two.Count; i++)
            {
                while(one.Contains(two[i]))
                {
                    one.Remove(two[i]);
                }
            }
            Console.WriteLine();
            foreach (string a in one)
            {
                Console.Write("{0} ",a);
            }
            Console.WriteLine();
    }
}

