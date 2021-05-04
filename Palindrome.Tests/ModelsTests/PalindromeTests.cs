using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    // Test methods go here
    [TestMethod]
    public void IsArray_ChangingStringToArray_True()
    {
      string testPalindrome = "racecar";
      // Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(true, testPalindrome.IsArray());
      // Assert.AreEqual(true, IsArray(testPalindrome));
    }
  }
}