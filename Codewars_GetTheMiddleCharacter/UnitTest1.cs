using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_GetTheMiddleCharacter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_stringEmpty_Should_Be_stringEmpty()
        {
            Assert.AreEqual(string.Empty, Kata.GetMiddle(string.Empty));
        }
    }

    public class Kata
    {
        public static string GetMiddle(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}
