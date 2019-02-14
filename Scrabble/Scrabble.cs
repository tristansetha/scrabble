using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to score:");

      string myString = Console.ReadLine();

      if (ScrabbleScorer.Validate(myString))
      {
        int myScore = ScrabbleScorer.Score(myString);

        Console.WriteLine("Score: " + myScore);
      }
      else
      {
        Console.WriteLine("Invalid string (contains non-alphabetic characters)");
      }
    }
  }
}
