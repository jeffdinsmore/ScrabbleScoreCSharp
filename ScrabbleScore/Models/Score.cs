using System.Collections.Generic;
using System;
using System.Linq;

namespace ScrabbleScore.Models
{
  public class Score
  {

    public int Letters(string letters)
    {
      Dictionary<string, int> letterValues = new Dictionary<string, int>() {{"A", 1}, {"E", 1}, {"I", 1}, {"O", 1}, {"U", 1}, {"L", 1}, {"N", 1}, {"R", 1}, {"S", 1}, {"T", 1}, {"D", 2}, {"G", 2}, {"B", 3}, {"C", 3}, {"M", 3}, {"P", 3}, {"F", 4}, {"H", 4}, {"V", 4}, {"W", 4}, {"Y", 4}, {"K", 5}, {"J", 8}, {"X", 8}, {"Q", 10}, {"Z", 10} };
      
      int sum = 0;
      for (int i = 0; i < letters.Length; i++)
      {
        sum = sum + letterValues[letters.Substring(i,1)];
      }

      return sum;
    }
    public string SplitLetters(string letters)
    {
      string output = letters.Substring(4,1);
      return output;
    }
    
  }
}