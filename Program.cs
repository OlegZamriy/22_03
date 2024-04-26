using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = { -5, 10, -15, 20, 25, -30, 35, -40, 45 };

        Func<int[], int> countPositiveNumbers = nums => nums.Count(num => num > 0);

        int count = countPositiveNumbers(numbers);

        Console.WriteLine($"Кількість позитивних чисел у масиві: {count}");
    }
}
