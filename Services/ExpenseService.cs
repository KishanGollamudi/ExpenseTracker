using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class ExpenseService
    {
        private List<Expense> expenses = new();

        public List<Expense> GetAll() => expenses;

        public void Add(Expense expense)
        {
            if (string.IsNullOrWhiteSpace(expense.Date))
            {
                expense.Date = DateTime.Now.ToString("yyyy-MM-dd");
            }

            expenses.Add(expense);
        }
    }
}

