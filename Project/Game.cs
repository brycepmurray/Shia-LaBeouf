using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        public List<Room> Rooms { get; set; }
        public Boolean Playing { get; set; }

        public void Reset()
        {
            Playing = true; ;
        }

        public void Setup()
        {
            Console.Clear();
            CurrentPlayer = new Player();
            if (CurrentPlayer.PlayerName == "D$" || CurrentPlayer.PlayerName == "DMONEY" || CurrentPlayer.PlayerName == "DARRYL")
            {
                Win();
                // DARRYL();
            }
        }
        // public void DARRYL()
        // {
        //     Console.WriteLine($@"
        //        You are Walking in the woods, 
        //        Theres no one around and your phone is dead, 
        //        out of the corner of your eye, you spot him....
        //        (whisper)Shia LaBeouf...
        //        ");
        //     Console.WriteLine($@"
        //        As if in response, the ground benieth you
        //        echos your pressence back towards your pursuer...
        //        In a rumbling whisper that would shake even the 
        //        strongest of men or women to the core you hear.....
        //        DDDDDDD MOOONNNEEEYYY...
        //     ");
        //     Console.WriteLine($@"
        //        Your Pursuer Stops Dead in his Tracks,
        //        Close enough to see that it is none other
        //         than Hollywood superstar Shia LaBeouf...
        //        You see absolute fear in his eyes and sweat 
        //        drip down his face....He Flees in terror
        //        knowing that he stands no chance against 
        //        the Being of Absolute Power D$!
        //     ");
        //     CurrentPlayer.Score++;
        //     DARRYL();
        // }
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