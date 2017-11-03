using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssessment201711
{
    public class TennisScorer
    {
        private const int _MaxScore = 4;

        public TennisResult GetResult(TennisScore player1, TennisScore player2)
        {
            if (player1 == TennisScore.Adventage)
                return TennisResult.AdventagePlayer1;
            if (player2 == TennisScore.Adventage)
                return TennisResult.AdventagePlayer2;

            var result = (TennisResult)(player1 + (int)player2 * _MaxScore);
            return result;
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
        LoveFifteen,
        FifteenFifteen,
        ThirtyFifteen,
        FortyFifteen,
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
