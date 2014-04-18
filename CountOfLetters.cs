using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    //Method for filling the Lists.
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
        string letters = Console.ReadLine();
        List<string> chars = Filler(letters);
        
        foreach (var group in chars.GroupBy(c => c).OrderByDescending(g => g.Count()))
        {
            Console.WriteLine(" {0}: {1}", group.Key, group.Count());
        }
    }
}

