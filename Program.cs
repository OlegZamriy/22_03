using System;

public class Program
{
    public static void Main()
    {
        Func<int, int> cube = num => num * num * num;

        int numberToCube = 3;

        int cubedNumber = cube(numberToCube);

        Console.WriteLine($"Куб числа {numberToCube} дорівнює {cubedNumber}.");
    }
}
