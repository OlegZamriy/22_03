using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Func<int[], int> findMax = numbers => numbers.Max();

        int[] array = { 5, 10, 15, 20, 25 };

        int maxNumber = findMax(array);

        Console.WriteLine($"Максимальне число в масиві: {maxNumber}");
    }
}
