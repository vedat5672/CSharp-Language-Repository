namespace DesignPattern.Strategy
{
    public class Before2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit Calculated using Before 2010");
        }
    } 
}
