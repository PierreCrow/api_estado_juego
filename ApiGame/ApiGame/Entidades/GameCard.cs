using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGame.Entidades
{
    public class GameCard
    {
        public GameCard(int id, string value, int idState, string descState)
        {
            Id = id;
            Value = value;
            IdState = idState;
            DescState = descState;
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public int IdState { get; set; }
        public string DescState { get; set; }

        //public int IsFlipped { get; set; }
        //public bool IsMatched { get; set; }
        //public bool IsIncorrect { get; set; }
    }
}
