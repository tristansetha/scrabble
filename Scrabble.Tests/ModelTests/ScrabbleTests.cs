using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void ScrabbleWord_IsAlphabetic_False()
    {
      Assert.AreEqual(false, ScrabbleScorer.Validate("Alphab3t1cstr1ng"));
    }

    [TestMethod]
    public void ScrabbleWord_IsAlphabetic_True()
    {
      Assert.AreEqual(true, ScrabbleScorer.Validate("Alphabeticstring"));
    }

    [TestMethod]
    public void ScrabbleWord_Score_AEIOULNRST()
    {
      Assert.AreEqual(10, ScrabbleScorer.Score("AEIOULNRST"));
    }

    [TestMethod]
    public void ScrabbleWord_Score_DG()
    {
      Assert.AreEqual(4, ScrabbleScorer.Score("DG"));
    }

    [TestMethod]
    public void ScrabbleWord_Score_BCMP()
    {
      Assert.AreEqual(12, ScrabbleScorer.Score("BCMP"));
    }

    [TestMethod]
    public void ScrabbleWord_Score_FHVWY()
    {
      Assert.AreEqual(20, ScrabbleScorer.Score("FHVWY"));
    }

    [TestMethod]
    public void ScrabbleWord_Score_K()
    {
      Assert.AreEqual(5, ScrabbleScorer.Score("K"));
    }

    [TestMethod]
    public void ScrabbleWord_Score_JX()
    {
      Assert.AreEqual(16, ScrabbleScorer.Score("JX"));
    }

    [TestMethod]
    public void ScrabbleWord_Score_QZ()
    {
      Assert.AreEqual(20, ScrabbleScorer.Score("QZ"));
    }

    [TestMethod]
    public void ScrabbleWord_Score_ALL()
    {
      Assert.AreEqual(87, ScrabbleScorer.Score("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
    }
  }
}
