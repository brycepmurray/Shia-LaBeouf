# Console Game Checkpoint

### The Setup

As you begin working on a console game the basic requirements of any good console game will allow users to:
  - Move about a set of rooms
  - Get a description of the room they are in
  - Get Help - Shows a list of all available commands
  - Use Items
  - Give Up 
  - Restart
  
To help you out with some of these basic features will notice that you already have some interfaces that have been built. These interfaces are designed to help ensure you implement the basic requirements of a console game. 

### Step 1 -  Satisfy the Interfaces 

To satisfy the interfaces you will need to ensure that your classes implement all of the features of the provided interfaces... You cannot remove anything from any of the interfaces. 
  The Basic Features of the game:
  - `Go <Direction>` Moves the player from room to room
  - `Use <ItemName>` Uses an item in a room or from your inventory
  - `Take <ItemName>` Places an item into the player inventory and removes it from the room
  - `Help` Shows a list of commands and actions
  - `Quit` Quits the Game

### Step 2 - Control the Game Loop

We have provided a basic story and map if you are not creative or simply don't want to spend your time thinking of a story to play your game. Following the provided story is not required however creating some sort of experience is. 

Your Game must implement the following features
  - At least 4 rooms
  - At least 1 usable item
  - At least 1 item that can be taken (can be the same as the usable item)
  - At least 1 room that changes based on an item use
  - When the player enters a room they get the room description
  - Players can see the items in their inventory
  - Players lose the game due to a bad decision
  - Players can win the game
  
  
 ## Functionality: 
 - Players can move room to room with the `go <direction>` command
 - Players can `use` items to change the state of the room (use key or use light)
 - Items exist for the player to `take` from rooms (not required for these to be used in a room)
 - `quit` ends the game
 - At least 4 rooms, 1 usable item, and 1 takeable item
 - Players can lose the game due to a bad decision
 - The game is winnable 

## Visualization: 
 - `help` Provides the user a list of commands for your game
 - `look` Re-prints the room description
 - `inventory` prints a list of the items in the players inventory
 -  When the player enters a room they get the room description
  
### BONUS IDEAS - Some enhancing features
- Try changing the console color or adding some beeps for dramatic effect
- Clear the console when appropriate
- The user should know when its their turn try formatting the users input with something like this everytime its the users turn to type
  - What do you do: __________________ // <- Their Answer on the same line
- Add some riddles or puzzles for users to solve to get from room to room

### Finished?
When You are finished please submit the url for your github repo to the gradebook.


<!-- You are Walking in the woods, Theres no one around and your phone is dead, out of the corner of your eye, you spot him....(whisper)Shia LaBeouf... -->

<!-- Hes following you, about thirty feet back. He gets on all fours and breaks into a sprint, hes gaining on you! Shia LaBeouf -->

<!-- Youre looking for your car but you're all turned around. He is almost upon you now, and you can see theres blood on his face. My God there is blood everywhere! -->

<!-- Running for your life from Shia LaBeouf, 
     Hes brandishing a knife, its Shia LaBeouf.
     lurking in the Shadows Hollywood superstar Shia LaBeouf
     Living in the woods Shia LaBeouf
     Killing for sprot, Shia LaBeouf
     Eating all the bodies....
     Actual Canibal Shia LaBeouf! -->

<!-- Now its Dark and you seem to have lost him, but you are hopelessly lost yourself. Stranded with a murderer. -->

<!-- You creep siliently through the underbrush. Aha in the distance, a small cottage with a light on. Hope. -->

<!-- You move stealthily towards it, but your leg, ah, its caught in a bear trap! -->

<!-- Gnawing off your leg, quiet, quiet.
     Limping to the cottage, quiet, quiet.
     Now you are on the doorstep
     Sitting inside, Shia LaBeouf
     Sharpening an axe, Shia LaBeouf
     But he doesnt hear you enter, Shia LaBeouf
     Youre sneaking up behind him, 
     Strangling superstar Shia LaBeouf.
     Fighting for your life with Shia LaBeouf!
     Wrestling a knife from Shia LaBeouf,
     stab it in his kidney, 
     safe at last from Shia LaBeouf..... -->

<!-- You Limp into the Dark Woods, blood oozing from your stump leg. Youve beaten Shia LaBeouf. -->

<!-- Wait he Isnt Dead! Shia Surprise!
     Theres a gun to your head, 
     and Death in his eyes, 
     But you can do Jiu-Jitsu.
     Body Slam Superstar Shia LaBeouf
     Legendary Fight with Shia LaBeouf
     Normal Tuesday night for Shia LaBeouf -->

<!-- You try to swing the axe at Shia LaBeouf -->

<!-- But blood is draining fast from your stump leg -->

<!-- Hes dodging every swipe, he parries to the left -->

<!-- You counter to the right, you catch him in the neck! -->

<!-- You're chopping off his head now -->

<!-- You have just decapitated Shia LaBeouf -->

<!-- His head topples to the floor, expresionless -->

<!-- You fall to your knees and catch your breath... -->

<!-- Youre finally safe from Shia LaBeouf. -->
