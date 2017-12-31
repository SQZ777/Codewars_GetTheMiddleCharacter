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

        [TestMethod]
        public void Input_CBBAC_Should_Be_B()
        {
            Assert.AreEqual("B", Kata.GetMiddle("CBBAC"));
        }

        [TestMethod]
        public void Input_ZPOOSSS_Should_Be_O()
        {
            Assert.AreEqual("O", Kata.GetMiddle("ZPOOSSS"));
        }

        [TestMethod]
        public void Input_AB_Should_Be_AB()
        {
            Assert.AreEqual("AB",Kata.GetMiddle("AB"));
        }

        [TestMethod]
        public void Input_ABCC_Should_Be_BC()
        {
            Assert.AreEqual("BC",Kata.GetMiddle("ABCC"));
        }
    }

    public class Kata
    {
        public static string GetMiddle(string str)
        {
            if (str.Length < 2) return str;
            if (str.Length % 2 == 1)
            {
                return str.Substring(str.Length / 2, 1);
            }
            else
            {
                return str.Substring(str.Length / 2 - 1, 2);
            }
        }
    }
}
