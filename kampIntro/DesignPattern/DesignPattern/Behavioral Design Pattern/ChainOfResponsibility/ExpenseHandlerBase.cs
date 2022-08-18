namespace DesignPattern.ChainOfResponsibility
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase? Successor;
        public abstract void HandleExpense(Expense expense);
        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor = successor;
        }
    }
    
}
