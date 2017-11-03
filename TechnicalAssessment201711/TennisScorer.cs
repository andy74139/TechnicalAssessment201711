using System;

namespace TechnicalAssessment201711
{
    public class TennisScorer
    {
        private readonly int _MaxScore = Enum.GetNames(typeof (TennisScore)).Length - 1;

        public TennisResult GetResult(TennisScore player1, TennisScore player2)
        {
            if (player1 == TennisScore.Adventage)
                return TennisResult.AdventagePlayer1;
            if (player2 == TennisScore.Adventage)
                return TennisResult.AdventagePlayer2;

            return (TennisResult)(player1 + (int)player2 * _MaxScore);
        }
    }
}
