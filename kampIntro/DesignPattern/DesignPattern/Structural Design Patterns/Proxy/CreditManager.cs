namespace DesignPattern.Proxy
{
    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 10; i++)
            {
                result *= i;
                Thread.Sleep(2000);
            }
            return result;
        }
    }
}
