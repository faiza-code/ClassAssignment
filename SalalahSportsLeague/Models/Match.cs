using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahSportsLeague.Models
{
    public class Match
    {
        public Team Team1 { get; }
        public Team Team2 { get; }
        public int ScoreTeam1 { get; private set; }
        public int ScoreTeam2 { get; private set; }
        public Team Winner { get; private set; }

        public Match(Team team1, Team team2)
        {
            Team1 = team1;
            Team2 = team2;
        }

        public void RecordResult(int scoreTeam1, int scoreTeam2)
        {
            ScoreTeam1 = scoreTeam1;
            ScoreTeam2 = scoreTeam2;

            if (scoreTeam1 > scoreTeam2)
                Winner = Team1;
            else if (scoreTeam2 > scoreTeam1)
                Winner = Team2;
            else
                Winner = null; // Draw

            Team1.RecordMatchResult(scoreTeam1, scoreTeam2);
            Team2.RecordMatchResult(scoreTeam2, scoreTeam1);
        }

        public override string ToString()
        {
            string winnerStr = Winner == null ? "Draw" : Winner.Name;
            return $"{Team1.Name} {ScoreTeam1} - {ScoreTeam2} {Team2.Name} | Winner: {winnerStr}";
        }
    }

}

