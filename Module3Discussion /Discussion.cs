// In my example, I will be using the Classes.txt as my reference
// I will use the 'Octopus' and 'Wine' classes to build a simple application that demonstrates:
// using fields & properties, constructors (including overloading), object initializers, and deconstructors

// Octopus.cs
using System;

public class Octopus
{
    // Fields
    public int Age = 10;
    public readonly string Name;
    public readonly int Legs = 8;

    // Constructor
    public Octopus(string name)
    {
        Name = name;
    }

    // Method to display information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Legs: {Legs}");
    }
}

// Wine.cs


public class Wine
{
    public decimal Price { get; set; }
    public int Year { get; set; }

    // Constructors
    public Wine(decimal price)
    {
        Price = price;
    }

    public Wine(decimal price, int year) : this(price)
    {
        Year = year;
    }

    // Method to display wine details
    public void DisplayWineInfo()
    {
        Console.WriteLine($"Price: {Price:C}, Year: {Year}");
    }
}

// Program.cs
class Program
{
    static void Main()
    {
        // Using Octopus class
        var octopusA = new Octopus("Mike");
        octopusA.DisplayInfo();

        var octopusB = new Octopus("Kraken") { Age = 3 }; // Object initializer
        octopusB.DisplayInfo();

        // Deconstruction example
        var (width, height) = new Rectangle(2, 5);
        Console.WriteLine($"Rectangle Width: {width}, Height: {height}");

        // Using Wine class
        var wine1 = new Wine(24.99m);
        wine1.DisplayWineInfo();

        var wine2 = new Wine(45.99m, 2015);
        wine2.DisplayWineInfo();
    }
}

// Rectangle class for deconstruction example
public class Rectangle
{
    public readonly float Width, Height;

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    // Deconstructor
    public void Deconstruct(out float width, out float height)
    {
        width = Width;
        height = Height;
    }
} 
