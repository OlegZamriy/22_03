using System;
using System.Collections.Generic;

public class Backpack
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Manufacturer { get; set; }
    public string Material { get; set; }
    public double Weight { get; set; }
    public double Volume { get; set; }
    public List<Item> Contents { get; private set; }

    public event EventHandler<ItemAddedEventArgs> ItemAdded;

    public Backpack(string color, string brand, string manufacturer, string material, double weight, double volume)
    {
        Color = color;
        Brand = brand;
        Manufacturer = manufacturer;
        Material = material;
        Weight = weight;
        Volume = volume;
        Contents = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if ((CalculateTotalVolume() + item.Volume) <= Volume)
        {
            Contents.Add(item);
            OnItemAdded(item);
        }
        else
        {
            throw new InvalidOperationException("Рюкзак переповнений. Неможливо додати об'єкт.");
        }
    }

    private double CalculateTotalVolume()
    {
        double totalVolume = 0;
        foreach (var item in Contents)
        {
            totalVolume += item.Volume;
        }
        return totalVolume;
    }

    protected virtual void OnItemAdded(Item item)
    {
        ItemAdded?.Invoke(this, new ItemAddedEventArgs(item));
    }
}

public class Item
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public Item(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }
}

public class ItemAddedEventArgs : EventArgs
{
    public Item AddedItem { get; private set; }

    public ItemAddedEventArgs(Item item)
    {
        AddedItem = item;
    }
}

public class Program
{
    public static void Main()
    {
        Backpack backpack = new Backpack("Black", "ExampleBrand", "ExampleManufacturer", "Nylon", 1.5, 20);

        backpack.ItemAdded += (sender, e) =>
        {
            Console.WriteLine($"Додано в рюкзак: {e.AddedItem.Name}");
        };

        try
        {
            backpack.AddItem(new Item("Book", 2.0));
            backpack.AddItem(new Item("Laptop", 4.0));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
