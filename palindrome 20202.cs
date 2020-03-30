using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace palindrome_unit_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPalindromeTrue()
        {
            var test = new Form1();
            String Word = "aassaa";
            string answer = test.CheckPalindrome(Word);
            Assert.AreEqual(Word + "is a palindrome", answer);
        }
        [TestMethod]
    }
    public void TestPalindromeFalse()
    {
        var test = new Form1();
        string Word = "aass";
        string answer = test.CheckPalindrome(Word);
        Assert.AreEqual(Word + "is not a palindrome");
    }
}
