using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = { -5, -10, -15, 20, -25, -30, 35, -40, 45, -5, -10 };

        Func<int[], IEnumerable<int>> uniqueNegativeNumbers = nums => nums.Where(num => num < 0).Distinct();

        var uniqueNegatives = uniqueNegativeNumbers(numbers);

        Console.WriteLine("Унікальні негативні числа у масиві:");
        foreach (var num in uniqueNegatives)
        {
            Console.WriteLine(num);
        }
    }
}
