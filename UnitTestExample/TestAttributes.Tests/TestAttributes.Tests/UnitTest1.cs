namespace TestAttributes.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,Description("JFDKJBFNBGFJKBNJBN")]
        [Owner("vedat")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("güncelleyen" ,"engin")]
        [TestProperty("güncelleyen2" ,"ahmet")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod,Ignore]
        [Owner("vedat")]
        [TestCategory("Tester")]
        [Priority(1)]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod,Timeout(1000)]
        [Owner("vedat")]
        [TestCategory("Tester")]
        [Priority(1)]
        public void TestMethod3()
        {
            Thread.Sleep(1500);
            Assert.AreEqual(1, 1);
        }
        [TestMethod,Ignore]
        [Owner("berfin")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod,Timeout(TestTimeout.Infinite)]
        [Owner("berfin")]
        [Priority(2)]
        [TestCategory("Developer")]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
     
    }
}