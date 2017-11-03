using System;
using NUnit.Framework;
using TechnicalAssessment201711;

namespace TechnicalAssessment201711Tests
{
    [TestFixture]
    public class TennisScorerTests
    {
        [TestCase(TennisScore.Love,    TennisScore.Love, ExpectedResult = TennisResult.LoveLove,    TestName = "LoveLove")]
        [TestCase(TennisScore.Fifteen, TennisScore.Love, ExpectedResult = TennisResult.FifteenLove, TestName = "FifteenLove")]
        [TestCase(TennisScore.Thirty,  TennisScore.Love, ExpectedResult = TennisResult.ThirtyLove,  TestName = "ThirtyLove")]
        [TestCase(TennisScore.Forty,   TennisScore.Love, ExpectedResult = TennisResult.FortyLove,   TestName = "FortyLove")]
        [TestCase(TennisScore.Love, TennisScore.Fifteen, ExpectedResult = TennisResult.LoveFifteen, TestName = "LoveFifteen")]
        [TestCase(TennisScore.Fifteen, TennisScore.Fifteen, ExpectedResult = TennisResult.FifteenFifteen, TestName = "FifteenFifteen")]
        [TestCase(TennisScore.Thirty, TennisScore.Fifteen, ExpectedResult = TennisResult.ThirtyFifteen, TestName = "ThirtyFifteen")]
        [TestCase(TennisScore.Forty, TennisScore.Fifteen, ExpectedResult = TennisResult.FortyFifteen, TestName = "FortyFifteen")]
        [TestCase(TennisScore.Love, TennisScore.Thirty, ExpectedResult = TennisResult.LoveThirty, TestName = "LoveThirty")]
        [TestCase(TennisScore.Fifteen, TennisScore.Thirty, ExpectedResult = TennisResult.FifteenThirty, TestName = "FifteenThirty")]
        [TestCase(TennisScore.Thirty, TennisScore.Thirty, ExpectedResult = TennisResult.ThirtyThirty, TestName = "ThirtyThirty")]
        [TestCase(TennisScore.Forty, TennisScore.Thirty, ExpectedResult = TennisResult.FortyThirty, TestName = "FortyThirty")]
        [TestCase(TennisScore.Love, TennisScore.Forty, ExpectedResult = TennisResult.LoveForty, TestName = "LoveForty")]
        [TestCase(TennisScore.Fifteen, TennisScore.Forty, ExpectedResult = TennisResult.FifteenForty, TestName = "FifteenForty")]
        [TestCase(TennisScore.Thirty, TennisScore.Forty, ExpectedResult = TennisResult.ThirtyForty, TestName = "ThirtyForty")]
        [TestCase(TennisScore.Forty, TennisScore.Forty, ExpectedResult = TennisResult.Deuce, TestName = "Deuce")]
        [TestCase(TennisScore.Adventage, TennisScore.Forty, ExpectedResult = TennisResult.AdventagePlayer1, TestName = "AdventagePlayer1")]
        [TestCase(TennisScore.Forty, TennisScore.Adventage, ExpectedResult = TennisResult.AdventagePlayer2, TestName = "AdventagePlayer2")]
        public TennisResult GetResultTests(TennisScore player1Score, TennisScore player2Score)
        {
            return new TennisScorer().GetResult(player1Score, player2Score);
        }
    }
}
