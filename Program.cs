using System;

public class Program
{
    public static void Main()
    {
        Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;

        // Тестування лямбда-виразу
        DateTime testDate1 = new DateTime(2023, 9, 13);
        DateTime testDate2 = new DateTime(2024, 9, 12);

        Console.WriteLine($"Дата {testDate1.ToShortDateString()} - день програміста? {isProgrammersDay(testDate1)}");
        Console.WriteLine($"Дата {testDate2.ToShortDateString()} - день програміста? {isProgrammersDay(testDate2)}");
    }
}
