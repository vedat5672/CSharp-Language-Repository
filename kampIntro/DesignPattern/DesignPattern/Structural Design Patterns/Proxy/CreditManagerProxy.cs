namespace DesignPattern.Proxy
{
    public class CreditManagerProxy : CreditBase
    {
        private CreditManager CreditManager;
        private int _cachedValue;
        public override int Calculate()
        {
            if (CreditManager==null)
            {
                CreditManager = new CreditManager();
                _cachedValue=CreditManager.Calculate();
            }
            return _cachedValue;
        }
    }
}
