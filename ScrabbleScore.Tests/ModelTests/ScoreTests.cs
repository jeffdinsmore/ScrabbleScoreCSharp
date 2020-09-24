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
      Score testLetter = new Score();
      string letter = "A";
      Assert.AreEqual(1, testLetter.Letters(letter));
    }

    [TestMethod]
    public void TestTwoLetters_TestIfTwoLetterReturnsSingleScore_ScoreOfLetters()
    {
      Score testLetters = new Score();
      string letter = "AE";
      Assert.AreEqual(2, testLetters.Letters(letter));
    }
  }
}