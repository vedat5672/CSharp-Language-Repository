namespace DesignPattern.Null_Object
{
    public class CustomerManagerTest
    {
        public void SaveTest()
        {
            CustomerManagerNO customerManager = new CustomerManagerNO(StubLogger.GetLogger());
            customerManager.Save();

        }
    }
}
