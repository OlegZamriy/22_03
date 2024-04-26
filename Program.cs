using System;

public class Program
{
    public static void Main()
    {
        Func<int, bool> isEven = delegate (int number)
        {
            return number % 2 == 0;
        };

        int numToCheck = 10;

        bool isNumEven = isEven(numToCheck);

        if (isNumEven)
        {
            Console.WriteLine($"{numToCheck} - парне число.");
        }
        else
        {
            Console.WriteLine($"{numToCheck} - непарне число.");
        }
    }
}
