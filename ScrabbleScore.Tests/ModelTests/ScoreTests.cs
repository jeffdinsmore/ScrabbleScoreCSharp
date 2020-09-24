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
    public void TestTwoLetters_TestIfLetterPulledFromGroup_SingleLetter()
    {
      Score testSplitLetters = new Score();
      string letters = "ABCDE";
      Assert.AreEqual("E", testSplitLetters.SplitLetters(letters));
    }

     [TestMethod]
    public void AddTwoLetterValues_TestIfTwoLettersReturnSingleScore_ScoreOfLetters()
    {
      Score testAddLetters = new Score();
      string letters = "AE";
      Assert.AreEqual(2, testAddLetters.Letters(letters));
    }

    [TestMethod]
    public void AddMultipleLetterValues_TestIfMultipleLettersReturnSingleScore_ScoreOfLetters()
    {
      Score testAddLetters = new Score();
      string letters = "Quiznos";
      string lettersUpperCase = letters.ToUpper();
      Assert.AreEqual(25, testAddLetters.Letters(lettersUpperCase));
    }
  }
}