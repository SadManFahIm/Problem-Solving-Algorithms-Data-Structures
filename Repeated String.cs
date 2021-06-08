using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var s = ReadLine();
        var n = long.Parse(Console.ReadLine());

        //find the occurence of a in input string s
        var count = 0L;
        foreach (var letter in s)
        {
            if (letter == 'a')
                count++;
        }

        var possibleStringRepeatitions = n / s.Length;
        count *= possibleStringRepeatitions;
        var offsetStringLength = n % s.Length;

        for (int i = 0; i < offsetStringLength; i++)
        {
            if (s[i] == 'a')
                count++;
        }

        WriteLine(count);
    }
}