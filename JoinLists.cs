using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    //Method for filling the Lists.
    private static List<int> Filler(string firstList)
    {
        List<string> listString = new List<string>();
        List<int> listInteger = new List<int>();
        char delimiter = ' ';
        string[] wordsOne = firstList.Split(delimiter);
        for (int i = 0; i < wordsOne.Length; i++)
        {
            listString.Add(wordsOne[i]);
        }
        for (int i = 0; i < listString.Count; i++)
        {
            listInteger.Add(int.Parse(listString[i]));
        }
            return listInteger;
    }
    //Checks the list for equal elements and removes it until there is no repeatable elements.
    public static List<int>Filter(List<int>listOne)
    {
        List<int>resultList=listOne.Distinct().ToList<int>();

        return resultList;
    }
    public static List<int> Result(List<int> listOne, List<int> listTwo)
    {
        List<int> result = new List<int>();
        listOne.AddRange(listTwo);
        
            return listOne;
    }
    static void Main()
    {
        string numsOne=Console.ReadLine();
        string numsTwo = Console.ReadLine();
        List<int> ListOne = Filler(numsOne);
        List<int> ListTwo = Filler(numsTwo);
        List<int> ListThree = Filter(ListOne);
        List<int> ListFour = Filter(ListTwo);
        List<int> ListFive = Result(ListThree,ListFour);
        List<int> Listfinal = ListFive.Distinct().ToList<int>();
        Listfinal.Sort();
        foreach (int a in Listfinal)
        {
            Console.Write("{0} ",a);
        }
        Console.WriteLine();
    }
}

