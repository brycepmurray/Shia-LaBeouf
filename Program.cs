using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World, Trevor sucks!");
            System.Console.WriteLine($@"
            
                   ########       ##           ##     ################             ##
                  ##       ##     ##           ##            ##                   ####
                  ##              ##           ##            ##                  ##  ##
                    ##            ##           ##            ##                 ##    ##
                      ##          ###############            ##                ##      ##
                        ##        ##           ##            ##               ############ 
                          ##      ##           ##            ##              ##          ##
                  ##       ##     ##           ##            ##             ##            ##
                    ########      ##           ##     ################     ##              ##

            ");

            Game.Game game = new Game.Game();
            game.PLaying = true;

            game.setup();
            game.buildRooms();
            game.Look(game.CurrentRoom);

            while (game.PLaying)
            {
                game.checkScore();
                string userChoice = game.GetUserInput().ToLower();
                string[] userAction = userChoice.Split(' ');
                if(userChoice == "clear")
                {
                    Console.Clear();
                }
                Room nextRoom;
                game.currentRoom.Exits.TryGetValue(userAction[0], out nextRoom);
                if(userAction[0] == "look" || userAction[0] == "1")
                {
                    game.Look (game.CurrentRoom);
                }
            }
        }
    }
}
