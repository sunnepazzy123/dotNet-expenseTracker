
public class Expense
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Amount { get; set; }

    public Expense(string name, string category, double amount)
    {
        Name = name;
        Category = category;
        Amount = amount;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} - {Category}: ${Amount:F2}");
    }
}
