using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrackers.API.Entities
{
    public class Game
    {
        public List<Player> Players { get; set; } = new();
        public List<Round> Rounds { get; set; } = new();
        public string GameId { get; set; }
    }
}
