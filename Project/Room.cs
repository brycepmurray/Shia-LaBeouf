using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Room : IRoom
    {
        public string Name {get; set; }
        public string Description {get; set;}
        public List <Item> Items {get; set;}
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();
        
      public Room(string name, string description,  List<Item> Items)
        {
            this.Name = Name;
            this.Description = Description;
            this.Exits = new Dictionary<string, Room>();
            this.Items = Items;
        }
        public void AddDoor(string direction, Room room)
        {
            Exits.Add(direction, room);
        }
        public void UseItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}