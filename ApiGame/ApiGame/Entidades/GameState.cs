using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGame.Entidades
{
    public class GameState
    {
        public int Id { get; set; }
        public List<GameCard> Cards { get; set; }
        public bool IsGameComplete { get; set; }
    }
}
