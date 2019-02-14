using System;

namespace Scrabble.Models
{
  public class ScrabbleScorer
  {
    public static bool CheckAlpha(string myString)
    {
      string _myStringUpper = myString.ToUpper();

      char[] myStringArray = _myStringUpper.ToCharArray();

      for (int i = 0; i < myStringArray.Length; i++)
      {
        if (myStringArray[i] < 'A' || myStringArray[i] > 'Z')
        {
          return false;
        }
      }
      return true;
    }

    public static bool Validate(string myString)
    {
      bool isAlpha = CheckAlpha(myString);

      return isAlpha;
    }

    public static int Score(string myString)
    {
      string _myStringUpper = myString.ToUpper();
      char[] myStringArray = _myStringUpper.ToCharArray();
      int myScore = 0;
      foreach (char myChar in myStringArray)
      {
        if (myChar == 'A' || myChar == 'E' || myChar == 'I'|| myChar == 'O' || myChar == 'U' || myChar == 'L' || myChar == 'N' || myChar ==  'R' || myChar == 'S' || myChar == 'T')
        {
          myScore += 1;
        } else if (myChar == 'D' || myChar == 'G')
        {
          myScore += 2;
        } else if (myChar == 'B' || myChar == 'C' || myChar == 'M' || myChar == 'P')
        {
          myScore += 3;
        } else if (myChar == 'F' || myChar == 'H' || myChar == 'V' || myChar == 'W' || myChar == 'Y')
        {
          myScore += 4;
        } else if (myChar == 'K')
        {
          myScore += 5;
        } else if (myChar == 'J' || myChar == 'X')
        {
          myScore += 8;
        } else if (myChar == 'Q' || myChar == 'Z')
        {
          myScore += 10;
        }
      }
      return myScore;
    }
  }
}
