using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    interface IPlayer
    {
        int Score { get; set; }
        List<Item> Inventory { get; set; }

    }
}