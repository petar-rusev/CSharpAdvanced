using System;
using System.Globalization;
class DifferenceDates
{
    static void Main()
    {
        Console.WriteLine("Please enter an exact date in format (dd.MM.yyyy) ");
        DateTime dateOne = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        DateTime dateTwo = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        TimeSpan diff = dateTwo - dateOne;
        string adapter = Convert.ToString(diff);
        char[] charsToTrim = { '0', '.', ':' };
        string result = adapter.Trim(charsToTrim);

        Console.WriteLine(result);
    }
}

