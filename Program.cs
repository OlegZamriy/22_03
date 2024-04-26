using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 7, 14, 21, 30, 35, 42, 49, 50, 63, 70 };

        Func<int[], int> countMultiplesOfSeven = nums => nums.Count(num => num % 7 == 0);

        int count = countMultiplesOfSeven(numbers);

        Console.WriteLine($"Кількість чисел у масиві, кратних семи: {count}");
    }
}
