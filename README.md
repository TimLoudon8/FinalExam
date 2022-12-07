# FinalExam
Timothy Loudon 100791672

WASD or arrow keys to move

I am using the starter code from the TA

Object Pooling: The ghosts are placed into the pool and a maximum of 4 are allowed to be on screen at the same time. Currently, the ghosts do not kill the player to show that when they collide with the player, they are set to inactive. A problem I had with this was that they would all spawn on top of each other and while they can be moved in the editor, this can't be known from the release build.

This implementation optimizes the scene by requiring less memory to be used when the game is started Screenshot: https://imgur.com/a/M5I9Otm

Command Pattern: When the 'Z' key is pressed, a pellet will spawn in a random location. Unfortunately, I was unable to have the command script put the pellet where it was before. Thihs benefits the game by being able to re-add pellets after the player has eaten them all, resulting in a higher score. It's functionality is present with a text box in game.

The final game management system that I added was a score manager. This score manager uses a singleton design pattern to display the player's current score at the top left side of the screen. I felt that this was a important inclusion because in a game like Pacman, it is a necessary feature to show the player their score at all times. While there is no text to tell the player how to earn points, like Pacman it is easy to distinguish between the ghosts and the collectibles and the player instantly knows how to add to their score once they touch these pellets.
