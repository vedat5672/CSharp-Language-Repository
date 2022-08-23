namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double enteredValue = 16;
            const double expected = 4;
            double actual=Math.Sqrt(enteredValue);
            Assert.AreEqual(expected,actual,"{0} number is sqrt {1}",enteredValue,expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double expected = 3.1622;
            // delta=|expected-actual|
            double delta = 0.001;// hata oraný
            double actual=Math.Sqrt(10);
            Assert.AreEqual(expected, actual, delta);

        }
        [TestMethod]
        public void TestMethod3()
        {
            string expected = "Merhaba";
            string actual = "merhaba";
            Assert.AreEqual(expected, actual, true); 
        }
        [TestMethod]
        public void TestMethod4()
        {
            const double expected = 0;
            var actual = Math.Pow(5, 0);
            Assert.AreNotEqual(expected, actual);
        }
       
        [TestMethod]
        public void TestMethod5()
        {
            int a = 10;
            int b = a;
            Assert.AreEqual(a, b, "AreEqual is Fail");
            Assert.AreSame(a, b, "AreSame is Fail");// Is Referance Same?
        }
        [TestMethod]
        public void TestMethod6()
        {
            var numbers = new byte[] { 1, 2, 3 };
            var otherNumbers = numbers;
            numbers[0] = 4;

            
            
            Assert.AreSame(numbers, otherNumbers, "AreSame is Fail");
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("bu test yeterli deðildir");
        }
        [TestMethod]
        public void TestMethod8()
        {
            var number = 5m;
            Assert.IsInstanceOfType(number, typeof(decimal));
            Assert.IsNotInstanceOfType(number, typeof(decimal));



           
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);
        }
        [TestMethod]
        public void TestMethod10()
        {
            List<string> numbers = new List<string> { "Vedat", "Berfin", "Yunus","Yusuf" };
            var startWithY = numbers.FirstOrDefault(a => a.StartsWith("X"));
            var startWithX = numbers.FirstOrDefault(a => a.StartsWith("V"));
            Assert.IsNull(startWithY, "Is Null is Failed");
            Assert.IsNotNull(startWithX, "Is Not Null is Failed");


        }
        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                var number = 5;
                int result = number / 1;
            }
            catch (DivideByZeroException)
            {

                Assert.Fail("the Test failed");
            }
        }

    }
}