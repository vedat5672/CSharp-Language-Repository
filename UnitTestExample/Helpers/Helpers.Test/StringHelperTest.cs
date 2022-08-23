namespace Helpers.Test
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void DeletedMoreSpaceTextEndandFinish()
        {
            //ARRANGE
            var text = "   vedat   arslan  ";
            var expected = "vedat arslan";
            var result=StringHelper.DeletedOfMoreSpace(text);
            //ASSERT
            Assert.AreEqual(expected, result);
        }
        public void DeletedMoreSpaceText()
        {
            //ARRANGE
            var text = "vedat       arslan  yunus   arslan   ";
            var expected = "vedat arslan yunus arslan";
            var result = StringHelper.DeletedOfMoreSpace(text);
            //ASSERT
            Assert.AreEqual(expected, result);
        }
    }
}