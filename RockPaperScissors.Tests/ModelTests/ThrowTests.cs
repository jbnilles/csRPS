using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class ThrowTests
  {
    Throw something = new Throw();
    [TestMethod]
    public void Compare_ComparesTwoThrowsToDetermineWinner_Winner()
    {
      Assert.AreEqual("User", something.Compare("Scissor", "Rock"));
    }
  }
}