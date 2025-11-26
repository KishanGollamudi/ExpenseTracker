using ExpenseTracker.Services;
using ExpenseTracker.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ExpenseService>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/expenses", (ExpenseService service) => service.GetAll());
app.MapPost("/api/expenses", (Expense expense, ExpenseService service) =>
{
    service.Add(expense);
    return Results.Ok(expense);
});

app.Run("http://0.0.0.0:5132");
