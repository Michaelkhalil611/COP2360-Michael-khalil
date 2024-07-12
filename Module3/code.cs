public class Octopus
{
    // Fields
    private string name;
    public int Age = 10;

    // Readonly fields
    public readonly int Legs = 8;
    public readonly int Eyes = 2;

    // Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Constructor
    public Octopus(string name)
    {
        this.name = name;
    }

    // Method to display octopus details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Legs: {Legs}, Eyes: {Eyes}");
    }
}

// Main program to create an instance of Octopus and display details
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Octopus
        Octopus octopus = new Octopus("Oliver");

        // Use the property to change the name
        octopus.Name = "Olivia";

        // Display octopus details
        octopus.DisplayDetails();
    }
}

