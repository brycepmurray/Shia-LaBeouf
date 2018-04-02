using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Player : IPlayer
    {
        public int Moves { get; set; }
        public List<Item> Inventory { get; set; }
        public int Score { get; set; }

        public Player()
        {
            Moves = 0;
            Score = 0;
            Inventory = new List<Item>();
        }
    }
}