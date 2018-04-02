using System;
using System.Collections.Generic;
using System.Linq;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player Player { get; set; }
        public List<Room> Rooms { get; set; }
        public Boolean Playing { get; set; }
        public Dictionary<string, Item> Items { get; set; }

        public Game()
        {
            Rooms = new List<Room>();
            Items = new Dictionary<string, Item>();
        }
        public void Reset()
        {
        }

        public void Setup()
        {
            Game game = new Game();
            Player player = new Player();
            game.Player = player;
        }
        public void Win()
        {
            Console.Clear();


        }

        public void UseItem(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}