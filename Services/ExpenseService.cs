namespace ExpenseTracker.Services;
using ExpenseTracker.Models;

public class ExpenseService
{
    private readonly List<Expense> _expenses = new();

    public List<Expense> GetAll()
    {
        return _expenses;
    }

    public void Add(Expense expense)
    {
        _expenses.Add(expense);
    }
}
