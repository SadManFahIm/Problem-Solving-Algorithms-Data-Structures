using System;
using System.Numerics;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var factorial = BigInteger.One;
        for (int i = 1; i <= n; i++)
            factorial = factorial * i;

        Console.WriteLine(factorial);
    }
}