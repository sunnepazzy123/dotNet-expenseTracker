
public class ExpenseTracker
{
    private static List<Expense> expenses = new List<Expense>();

    public static void Run()
    {
        bool running = true;

        while (running)
        {
            Utils.DisplayMenu();

            string? choice = Console.ReadLine();

            switch (choice)
            {

                case "1":

                    string name = Utils.DisplayAndCaptureInput("Enter Expense Name: ");

                    string category = Utils.DisplayAndCaptureInput("Enter Category (Food, Travel, Shopping, Other): ");

                    // Console.Write("Enter Amount: ");
                    string amountInput = Utils.DisplayAndCaptureInput("Enter Amount: ");

                    // Attempt to parse the input immediately
                    double amount = 0;
                    bool isValidAmount = double.TryParse(amountInput, out amount);

                    if (isValidAmount)
                    {
                        expenses.Add(new Expense(name, category, amount));
                        Console.WriteLine("Expense added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount! Please enter a valid number.");
                    }

                    break;

                case "2":
                    Console.WriteLine("\nYour Expenses:");
                    foreach (var expense in expenses)
                    {
                        expense.Display();
                    }
                    break;

                case "3":
                    double total = 0;
                    foreach (var expense in expenses)
                    {
                        total += expense.Amount;
                    }
                    Console.WriteLine($"Total Expense: ${total:F2}");
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option!.");
                    break;
            }

        }
    }
}

