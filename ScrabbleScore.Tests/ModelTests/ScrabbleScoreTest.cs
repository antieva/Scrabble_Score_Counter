using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScoreApp.Models;
using System;

namespace ScrabbleScoreApp.Tests
{
  [TestClass]
  public class ScrabbleScoreTest
  {
    [TestMethod]
    public void Score_Word_8()
    {
      int testScore = 8;
      int score = ScrabbleScore.Score("WORD");
      Console.WriteLine(score);
      Assert.AreEqual(testScore, score);
    }
  }
}
