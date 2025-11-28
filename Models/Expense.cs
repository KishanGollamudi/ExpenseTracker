namespace ExpenseTracker.Models
{
    public class Expense
    {
        public string? User { get; set; } = "";
        public string? Description { get; set; } = "";
        public double Amount { get; set; }
        public string? Category { get; set; } = "";
        public string? Date { get; set; } = "";
    }
}

