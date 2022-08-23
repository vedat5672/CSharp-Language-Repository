using static System.Net.Mime.MediaTypeNames;

namespace AssemplyLevel
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void ClassInýtialaize(TestContext testContext)
        {
            Console.WriteLine("Running unit test1 ClassInitialize");
        }
      
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("Running unit test1 Test Initialize");
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            Console.WriteLine("Running unit test1 test clean up");
        }
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Running Test Method");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            Console.WriteLine("Running unit test1 Class clean up");
        }
    }
}