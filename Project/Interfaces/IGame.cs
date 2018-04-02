using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    interface IGame
    {
        Room CurrentRoom { get; set; }
        Player Player { get; set; }

        void Setup();
        void Reset();

        //No need to Pass a room since Items can only be used in the CurrentRoom
        void UseItem(string itemName);

    }
}
