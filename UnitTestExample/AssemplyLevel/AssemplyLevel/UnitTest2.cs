using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemplyLevel
{
    [TestClass]
    public  class UnitTest2
    {
        [AssemblyInitialize]
        public static void AssemplyInitialize(TestContext testContext)
        {
            Console.WriteLine("Running unit test2  AssemplyInitialize ");
        }
     
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Console.WriteLine("Running unit test2  ClassInitialize ");
        }
    
        [TestInitialize]
        public  void TestInitialize()
        {
            Console.WriteLine("Running unit test2  TestInitialize ");
        }
    
        [TestMethod]
        public void Method1()
        {
            Console.WriteLine("Running unit test2  TestMethod ");
        }
      
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Console.WriteLine("Running unit test2  AssemblyCleanup ");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("Running unit test2  ClassCleanup ");
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("Running unit test2  TestCleanup ");
        }
    }
}
