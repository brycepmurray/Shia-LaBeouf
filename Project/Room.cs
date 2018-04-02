using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Room : IRoom
    {
        public string Name {get; set; }
        public string Description {get; set;}
        public Dictionary <string, Item> Items {get; set;}
        public Dictionary<string, Room> Directions = new Dictionary<string, Room>();
        
      public Room(string name, string description)
        {
            this.Name = Name;
            this.Description = Description;
            this.Directions = new Dictionary<string, Room>();
            this.Items = new Dictionary<string, Item>();
        }
        public void UseItem(Item item)
        {
        }
    }
}