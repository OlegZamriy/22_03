using System;

public class RainbowColorConverter
{
    public Func<string, string> GetRGBColorValue = (color) =>
    {
        switch (color.ToLower())
        {
            case "red":
                return "255, 0, 0";
            case "orange":
                return "255, 165, 0";
            case "yellow":
                return "255, 255, 0";
            case "green":
                return "0, 255, 0";
            case "blue":
                return "0, 0, 255";
            case "indigo":
                return "75, 0, 130";
            case "violet":
                return "238, 130, 238";
            default:
                return "Invalid color";
        }
    };
}

public class Program
{
    public static void Main()
    {
        RainbowColorConverter converter = new RainbowColorConverter();

        string redRGB = converter.GetRGBColorValue("red");
        Console.WriteLine("Red RGB: " + redRGB);

        string yellowRGB = converter.GetRGBColorValue("yellow");
        Console.WriteLine("Yellow RGB: " + yellowRGB);

        string invalidColorRGB = converter.GetRGBColorValue("purple");
        Console.WriteLine("Invalid Color RGB: " + invalidColorRGB);
    }
}
