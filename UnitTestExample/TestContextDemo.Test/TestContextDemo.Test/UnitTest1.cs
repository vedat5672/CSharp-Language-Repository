namespace TestContextDemo.Test
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("Test Initiliaze");
            TestContext.WriteLine("Test Adý    : {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu : {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sýnýfý : {0}", TestContext.FullyQualifiedTestClassName);
            TestContext.Properties["knowledge"] = "this is an extra information";
            Assert.AreEqual(1, 1);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("Test clean up");
            TestContext.WriteLine("Test Adý    : {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu : {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sýnýfý : {0}", TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Test Bilgi : {0}", TestContext.Properties["knowledge"]);
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("Test Medthod");
            TestContext.WriteLine("Test Adý    : {0}",TestContext.TestName);
            TestContext.WriteLine("Test Durumu : {0}",TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sýnýfý : {0}",TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Test Bilgi : {0}", TestContext.Properties["knowledge"]);
            Assert.AreEqual(1, 1);
        }

    }
}