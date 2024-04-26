using System;

public class Program
{
    public static void Main()
    {
        Func<int[], int> findMin = numbers => numbers.Min();

        int[] array = { 5, 10, 15, 20, 25 };

        int minNumber = findMin(array);

        Console.WriteLine($"Мінімальне число в масиві: {minNumber}");
    }
}
