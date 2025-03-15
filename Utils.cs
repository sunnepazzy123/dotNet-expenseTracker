
public class Utils
{
    public static void DisplayMenu()
    {
        Console.WriteLine("\nExpense Tracker");
        Console.WriteLine("1. Add Expense");
        Console.WriteLine("2. View Expenses");
        Console.WriteLine("3. Get Total Expense");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option: ");
    }

    public static string DisplayAndCaptureInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? string.Empty;
    }
}
