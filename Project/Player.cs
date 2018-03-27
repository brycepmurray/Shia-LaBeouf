using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Player : IPlayer
    {
        public string PlayerName;
        public List<Item> Inventory { get; set; }
        public int Score { get; set; }

        public Player()
        {
            PlayerName = NamePlayer();
            Score = 0;
            Inventory = new List<Item>();
        }
        public string NamePlayer()
        {
        Console.WriteLine("What would you like to be known by?");
        string name = Console.ReadLine();
        
        }
    }
}