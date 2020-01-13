using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenge1Lib;

namespace CodeChallenge1Test
{
    [TestClass]
    public class TestCodeChallenge1
    {
        CodeChallenge1 codeChallenge = new CodeChallenge1();

        [TestMethod]
        public void TestIsPalindrome()
        {
            string str1 = "nurses run";
            string str2 = "racecaR";
            string str3 = "1221";
            string str4 = "never odd, or even";

            Assert.AreEqual(true, codeChallenge.IsPalindrome(str1));
            Assert.AreEqual(true, codeChallenge.IsPalindrome(str2));
            Assert.AreEqual(true, codeChallenge.IsPalindrome(str3));
            Assert.AreEqual(true, codeChallenge.IsPalindrome(str4));
        }
    }
}
