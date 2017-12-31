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
            Assert.AreEqual("A", Kata.GetMiddle("A"));
        }

        [TestMethod]
        public void Input_ABC_Should_Be_B()
        {
            Assert.AreEqual("B", Kata.GetMiddle("ABC"));
        }


    }

    public class Kata
    {
        public static string GetMiddle(string str)
        {
            if (str.Length < 2) return str;
            return str.Substring(str.Length / 2, 1);
        }
    }
}
