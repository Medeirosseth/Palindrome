using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void ToArray_ChangingStringToArray_Array()
    {
      string testPalindrome = "racecar";
      // Palindrome testPalindrome = new Palindrome();
      // Assert.AreEqual(true, testPalindrome.IsArray());
      Assert.AreEqual(palindromeArray, ToArray(testPalindrome));
    
    }
  }
}