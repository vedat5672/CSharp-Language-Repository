namespace DesignPattern.ChainOfResponsibility
{
    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount<=100)
            {
                Console.WriteLine("Manager handled the expense!");
            }
            else if (Successor!=null)
            {
                Successor.HandleExpense(expense);
            }
         
        }
    } 
    
}
