using ClassAssignment.SalalahSportsLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahSportsLeague
{
    public class SalalahSportsLeague
    {
        private List<Team> teams = new List<Team>();
        private List<Match> matches = new List<Match>();

        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public IEnumerable<Team> Teams => teams;

        public Match ScheduleMatch(Team team1, Team team2)
        {
            var match = new Match(team1, team2);
            matches.Add(match);
            return match;
        }

        public IEnumerable<Match> Matches => matches;

        public IEnumerable<Team> GetStandings()
        {
            return teams.OrderByDescending(t => t.Points)
                        .ThenByDescending(t => t.GoalsFor - t.GoalsAgainst)
                        .ThenByDescending(t => t.GoalsFor);
        }

       
        public static void Main()
        {
            var league = new SalalahSportsLeague();

            var teamA = new Team("Salalah Strikers", "Coach Ahmed");
            teamA.AddPlayer(new Player(1, "Player 1"));
            teamA.AddPlayer(new Player(2, "Player 2"));
            league.AddTeam(teamA);

            var teamB = new Team("Haffa Warriors", "Coach Fatima");
            teamB.AddPlayer(new Player(3, "Player 3"));
            teamB.AddPlayer(new Player(4, "Player 4"));
            league.AddTeam(teamB);

            var match1 = league.ScheduleMatch(teamA, teamB);
            match1.RecordResult(3, 2);

            var match2 = league.ScheduleMatch(teamB, teamA);
            match2.RecordResult(1, 1);

            Console.WriteLine("Match Results:");
            foreach (var match in league.Matches)
            {
                Console.WriteLine(match);
            }

            Console.WriteLine("\nStandings:");
            foreach (var team in league.GetStandings())
            {
                Console.WriteLine(team);
            }
        }
    }
}
