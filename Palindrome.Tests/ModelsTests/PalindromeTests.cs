using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void ReturnString_SavesUserStringInToAVariable_String()
    {
      string userInput = "racecar";
      Palindrome testUserString = new Palindrome();
      Assert.AreEqual(true, testUserString.UserString(userInput));
      // Palindrome testPalindrome = new Palindrome();
      // Assert.AreEqual(true, testPalindrome.IsArray());
      // Assert.AreEqual(palindromeArray, ToArray(testPalindrome));
    
    }
  }
}