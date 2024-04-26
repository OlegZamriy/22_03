using System;

public class Program
{
    public static void Main()
    {
        Func<int, int> square = delegate (int num)
        {
            return num * num;
        };

        int numberToSquare = 5;

        int squaredNumber = square(numberToSquare);

        Console.WriteLine($"Квадрат числа {numberToSquare} дорівнює {squaredNumber}.");
    }
}
