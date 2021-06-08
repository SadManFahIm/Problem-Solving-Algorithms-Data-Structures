using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var tokens_d1 = Console.ReadLine().Split(' ');
        var actualDay = int.Parse(tokens_d1[0]);
        var actualMonth = int.Parse(tokens_d1[1]);
        var actualYear = int.Parse(tokens_d1[2]);
        var tokens_d2 = Console.ReadLine().Split(' ');
        var expectedDay = int.Parse(tokens_d2[0]);
        var expectedMonth = int.Parse(tokens_d2[1]);
        var expectedYear = int.Parse(tokens_d2[2]);
        var fine = 0;

        if (actualYear > expectedYear)
            fine = 10000;
        else if (actualYear == expectedYear)
        {
            if (actualMonth > expectedMonth)
                fine = 500 * (actualMonth - expectedMonth);
            else
            {
                if (actualMonth == expectedMonth)
                {
                    if (actualDay > expectedDay)
                        fine = 15 * (actualDay - expectedDay);
                }
            }
        }
        WriteLine(fine);
    }
}