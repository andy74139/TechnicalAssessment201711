using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssessment201711
{
    public class TennisScorer
    {
        public TennisResult GetResult(TennisScore player1, TennisScore player2)
        {
            return 0;
        }
    }

    public enum TennisScore
    {
        Love = 0, 
        Fifteen, 
        Thirty, 
        Forty, 
        Adventage
    }

    public enum TennisResult
    {
        LoveLove = 0, 
        FifteenLove, 
        ThirtyLove, 
        FortyLove,
        LoveFifty,
        FifteenFifty,
        ThirtyFifty,
        FortyFifty,
        LoveThirty,
        FifteenThirty,
        ThirtyThirty,
        FortyThirty,
        LoveForty,
        FifteenForty,
        ThirtyForty,
        Deuce,
        AdventagePlayer1, 
        AdventagePlayer2
    }
}
