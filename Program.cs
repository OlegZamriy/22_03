using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Func<int[], IEnumerable<int>> findOddNumbers = numbers => numbers.Where(num => num % 2 != 0);

        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var oddNumbers = findOddNumbers(array);

        Console.WriteLine("Непарні числа в масиві:");
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
