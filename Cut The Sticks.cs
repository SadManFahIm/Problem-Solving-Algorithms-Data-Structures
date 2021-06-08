using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var arr_temp = Console.ReadLine().Split(' ');
        var sticks = Array.ConvertAll(arr_temp, Int32.Parse);
        var sortedSticks = sticks.OrderByDescending(x => x).ToList(); //LINQ sorting uses stable quick sort

        while (n > 0)
        {
            Console.WriteLine(n);
            var smallestStickLength = sortedSticks[n - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                sortedSticks[i] -= smallestStickLength;
                if (sortedSticks[i] == 0)
                    n--;
            }
        }
    }
}