using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Player CurrentPlayer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Setup()
        {
            throw new NotImplementedException();
        }

        public void UseItem(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}