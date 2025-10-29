using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahSportsLeague.Models
{
    public class Team
    {
        public string Name { get; }
        public string Coach { get; }
        private List<Player> players = new List<Player>();

        public Team(string name, string coach)
        {
            Name = name;
            Coach = coach;
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public IReadOnlyList<Player> Players => players.AsReadOnly();

        
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public int Draws { get; private set; }
        public int GoalsFor { get; private set; }
        public int GoalsAgainst { get; private set; }

        public void RecordMatchResult(int goalsFor, int goalsAgainst)
        {
            GoalsFor += goalsFor;
            GoalsAgainst += goalsAgainst;

            if (goalsFor > goalsAgainst)
                Wins++;
            else if (goalsFor < goalsAgainst)
                Losses++;
            else
                Draws++;
        }

        public int Points => Wins * 3 + Draws;

        public override string ToString()
        {
            return $"{Name} - Coach: {Coach}, W:{Wins}, D:{Draws}, L:{Losses}, GF:{GoalsFor}, GA:{GoalsAgainst}, Points:{Points}";
        }
    }

}

