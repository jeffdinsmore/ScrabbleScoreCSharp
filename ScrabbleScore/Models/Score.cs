using System.Collections.Generic;
using System;
using System.Linq;

namespace ScrabbleScore.Models
{
  public class Score
  {

    public int Letters(string letter)
    {
      Dictionary<string, int> letterValues = new Dictionary<string, int>() {{"A", 1}, {"E", 1}};

      int output = letterValues[letter];
      return output;
    }
  }
}