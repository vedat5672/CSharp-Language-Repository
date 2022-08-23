using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        public DataRow data { get; set; }
      

        [TestMethod]
        [DataTestMethod]
       
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"C:\Users\Monster\Desktop\C# Language Repository\UnitTestExample\DataDriverUnitTestDemo\BusinessLayer.Tests\users.xml", "users", DataAccessMethod.Sequential)]
        
        [DataRow("name", "phone", "email")]
        public void DataTest()
        {
            var num1 = (double)TestContext.DataRow["NumberOne"];
            UserManager userManager = new UserManager();
            var name = data[0].ToString();
            var result = userManager.AddUsers(name,"","");
            Assert.IsTrue(result);
        }
    }
}