using System;

class SumOfChars
{
    static void Main()
    {   
        int n = int.Parse(Console.ReadLine());

        int totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            totalSum += (int)char.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The sum equals: {totalSum}");
    }
    
}