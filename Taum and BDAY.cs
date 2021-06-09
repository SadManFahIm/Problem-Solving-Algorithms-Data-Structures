using System;
using static System.Console;
class Solution
{
    static void Main(String[] args)
    {
        int numberOfTestCases = int.Parse(ReadLine());
        for (int a0 = 0; a0 < numberOfTestCases; a0++)
        {
            var tokens_b = ReadLine().Split(' ');
            var blackGiftsCount = Int64.Parse(tokens_b[0]);
            var whiteGiftsCount = Int64.Parse(tokens_b[1]);
            var tokens_x = ReadLine().Split(' ');
            var costBlackGift = Int64.Parse(tokens_x[0]);
            var costWhiteGift = Int64.Parse(tokens_x[1]);
            var conversionCost = Int64.Parse(tokens_x[2]);

            if (costBlackGift + conversionCost < costWhiteGift)
                costWhiteGift = costBlackGift + conversionCost;
            else if (costWhiteGift + conversionCost < costBlackGift)
                costBlackGift = costWhiteGift + conversionCost;
            WriteLine(blackGiftsCount * costBlackGift + whiteGiftsCount * costWhiteGift);
        }
    }
}