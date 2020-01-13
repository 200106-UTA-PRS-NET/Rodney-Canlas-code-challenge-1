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
            string strTrue1 = "nurses run";
            string strTrue2 = "racecaR";
            string strTrue3 = "1221";
            string strTrue4 = "never odd, or even";

            Assert.AreEqual(true, codeChallenge.IsPalindrome(strTrue1));
            Assert.AreEqual(true, codeChallenge.IsPalindrome(strTrue2));
            Assert.AreEqual(true, codeChallenge.IsPalindrome(strTrue3));
            Assert.AreEqual(true, codeChallenge.IsPalindrome(strTrue4));

            string strFalse1 = "one two one";
            string strFalse2 = "123abccba123";

            Assert.AreEqual(false, codeChallenge.IsPalindrome(strFalse1));
            Assert.AreEqual(false, codeChallenge.IsPalindrome(strFalse2));

        }
    }
}
