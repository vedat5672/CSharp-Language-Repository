namespace DesignPattern.Strategy
{
    public class CustomerManagerStrategy
    {
        public CreditCalculatorBase CreditCalculator { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer Manager Business");
            CreditCalculator.Calculate();
        }
    }
}
