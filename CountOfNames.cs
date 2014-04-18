using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
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
        string names=Console.ReadLine();
        List<string> namesList = Filler(names);
        var sortedList = namesList.OrderBy(x => x).ToList();
        foreach (var group in sortedList.GroupBy(c => c))
        {
            Console.WriteLine(" {0}: {1}", group.Key, group.Count());
        }
    }
}

