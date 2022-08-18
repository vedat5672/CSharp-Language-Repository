namespace DesignPattern.Strategy
{
    public class After2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit Calculated using After 2010"); 
        }
    }
}
