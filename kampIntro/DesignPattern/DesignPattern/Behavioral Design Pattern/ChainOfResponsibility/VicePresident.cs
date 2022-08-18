namespace DesignPattern.ChainOfResponsibility
{
    public class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount<=1000)
            {
                Console.WriteLine("VicePrecident handled the expense!");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
    
}
