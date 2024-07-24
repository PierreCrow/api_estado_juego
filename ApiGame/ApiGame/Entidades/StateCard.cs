using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGame.Entidades
{
    public class StateCard
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public StateCard(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
