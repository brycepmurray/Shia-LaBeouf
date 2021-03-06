using System.Collections.Generic;

namespace CastleGrimtol.Project
{
     interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        Dictionary<string, Item> Items { get; set; }

        void UseItem(Item item);
    }
}