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

            Item axe = new Item("axe", "A standard sized axe used for chopping large blocks of wood...or something more...");

            game.Items.Add("axe", axe);

            //  Name = name;
            // Description = description;
            // Directions = new Dictionary<string, Room>();
            // Items = new Dictionary<string, Item>();

            Room woods = new Room("The Woods","You are in The Woods, its night and your phone is dead It looks like forward might be your only option");
            Room deeperWoods = new Room("Deeper in The Woods", "There is a man chasing you on all fours deep in the woods! you can either try and fight him, or try and escape!");
            Room hidingPlace = new Room("HidingPlace", "You creep siliently through the underbrush. Aha in the distance, a small cottage with a light on. Hope. You can go to the cottage, or risk it in the woods with Shia Labeuf");
            Room outsideCottage = new Room("Outside The Cottage", "You are on the Doorstep of the cotage, you can burst in, and enter, leave the cottage to bleed out in your hiding place, or look into the window....");
            Room insideCottage = new Room("InsideCottage", "You are in the cottage and Shia LaBeuf is sitting in a chair sharpening an axe... you can leave, or sneak up behind him and strangle him");
            Room darkWoods = new Room("Dark Woods", "Wait! Shia isnt Dead and he has a gun to your head! You can either do Jiu-Jitsu, or give up and just let him shoot you");
            Room battleRoom = new Room("The Battle", "You body slammed Shia LaBeuf! You can either take the time to pick up the axe and fight him, or go straight to the fight!");
            Room finalRoom = new Room("Winning Room", "You walk away from the fight with a stump leg, but your life...You can leave the woods, or stay there and bleed out");

            woods.Directions.Add("go forward", deeperWoods);
            deeperWoods.Directions.Add("turn around", woods);
            deeperWoods.Directions.Add("run away", hidingPlace);
            hidingPlace.Directions.Add("give up", deeperWoods);
            hidingPlace.Directions.Add("move towards Cottage", outsideCottage);
            outsideCottage.Directions.Add("Go back to your cover", hidingPlace);
            outsideCottage.Directions.Add("look through the window", insideCottage);
            insideCottage.Directions.Add("try and leave the Cottage", outsideCottage);
            insideCottage.Directions.Add("sneak towards Shia", darkWoods);
            darkWoods.Directions.Add(" use Jiu-Jitsu", battleRoom);
            battleRoom.Directions.Add("fight!", finalRoom);

            battleRoom.Items.Add("axe", axe);

            game.Rooms.Add(woods);
            game.Rooms.Add(deeperWoods);
            game.Rooms.Add(hidingPlace);
            game.Rooms.Add(outsideCottage);
            game.Rooms.Add(insideCottage);
            game.Rooms.Add(darkWoods);
            game.Rooms.Add(battleRoom);
            game.Rooms.Add(finalRoom);
                        
            game.Playing();
        }

        public void Playing()
        {
            Console.Clear();
            this.CurrentRoom = this.Rooms[0];
            bool playing = true;
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