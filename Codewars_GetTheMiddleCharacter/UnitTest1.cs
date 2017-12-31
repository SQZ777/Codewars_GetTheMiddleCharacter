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

        [TestMethod]
        public void Input_A_Should_Be_A()
        {
            Assert.AreEqual("A",Kata.GetMiddle("A"));
        }

    }

    public class Kata
    {
        public static string GetMiddle(string str)
        {
            return str;
        }
    }
}
