using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahSportsLeague.Models
{
    public class Player
    {
        public int Id { get; }
        public string Name { get; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

}
