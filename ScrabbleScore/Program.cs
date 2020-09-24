using System;

namespace ScrabbleScore.Models
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Scrabble Score!");
      Console.WriteLine(@"                            ");
      Console.WriteLine("Input a word and get the score you would have in Scrabble:");
      string inputWord = Console.ReadLine().ToUpper();
      Score mainScore = new Score();
      string output = "Your Score is: " + mainScore.Letters(inputWord).ToString();
      Console.WriteLine("---------------------------");
      Console.WriteLine(output);
    }
  }
}