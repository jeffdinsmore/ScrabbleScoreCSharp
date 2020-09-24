using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
// using Score;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void TestLetter_TestLetterReturnsSingleScore_ScoreOfLetter()
    {
      // testing code will go here
      Score testLetter = new Score();
      string letter = "A";
      Assert.AreEqual(2, testLetter.Letters(letter));
    }

  
  }
}