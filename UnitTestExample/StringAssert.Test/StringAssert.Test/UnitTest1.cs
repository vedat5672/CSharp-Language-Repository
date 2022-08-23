using System.Text.RegularExpressions;

namespace StringAsserts.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringAssert.Contains("hello in Test world", "in");

        }
        [TestMethod]
        public void TestMethod2()
        {
            StringAssert.Matches("hello in Test world", new Regex(@"[a-zA-z]"));
            StringAssert.DoesNotMatch("hello in Test world", new Regex(@"[0-9]"));

        }
        [TestMethod]
        public void TestMethod3()
        {
            StringAssert.StartsWith("hello in Test world", "hello");

        }
        [TestMethod]
        public void TestMethod4()
        {
            StringAssert.EndsWith("hello in Test world", "world");

        }
    }
}