using System;

class Solution
{
    static void Main(String[] args)
    {

        var englishText = Console.ReadLine();
        var colCount = (int)Math.Ceiling(Math.Sqrt(englishText.Length));

        for (int i = 0; i < colCount; i++)
        {
            var counter = 0;
            while (i + (counter * colCount) < englishText.Length)
            {
                Console.Write(englishText[i + (counter * colCount)]);
                counter++;
            }
            Console.Write(' ');
        }
    }
}