# Change Logs
Comprehensive overview of updates, changes, and submitted Unity packages after each lesson, with a clear timeline of modifications and corresponding submission dates. Unity package files of the projects are located in the "Submitted Unity Packages" folder.

### 12/03/2023 - CarsGameFederico.unitypackage
I completed all of Unit 1, including the Bonus Features. The game I exported has a blue car with the ability to move it back and forth, to turn left and right. The Main Camera follows the blue car, it can change its position by pressing of the left CTRL key, and it turns slightly following the rotation of the vehicle. I have also included green vehicles that move towards the player, as requested in the homework. I have also included obstacles scattered around the map, all with a rigid body just like the rest of the vehicles. I have also implemented multiplayer which can be enabled and disabled by pressing the "1" key. When the button is pressed, Player 1's screen will be split, and the commands to move Player 2 will be enabled. Player 2 also has the same camera that follows the player, changes position with the press of the right CTRL key, and turns slightly following the rotation of the vehicle. Pressing the "1" key again will disable Player 2, the controls to move the vehicle will be disabled with an intentional error, and Player 1's camera will return to full screen.
I have also added on-screen texts describing the basic controls of the game, with the texts relating to Player 2 only being visible when playing with two players.

### 26/03/2023 - SpaceChickensFederico.unitypackage
I completed all of Unit 2, including all the Bonus Features. The final game is called 'Space Chickens' and I chose to put the models of the Chick, Chickens and Rooster scaled up, in a moon-like backgound. The animals have the ability to walk in the direction they are facing, each moving at a different speed, and they are destroyed when they move outside of the bounds of the screen. Animals spawn from above, left or right, thanks to a Switch Case in the code that determines their position of spawn. The Player can move both horizontally and vertically, limited to the screen, and shoot Corn Bullets (custom model) to feed the Chickens. Animals possess a hunger bar, with different values for each of them, and it can be filled by the Player's bullets to make the animal disappear. Each time an animal disappears, the Player's Score is increased according to the number of Corn the target has eaten. The Player also possesses 3 Lives, which are decreased each time he collides with an animal. If he runs out of all Lives, the game ends and everything is stopped thank to 'Time.timeScale = 0'.
I have also added an actual UI, in which are displayed a small desription of the game, the Lives remaining, the current Score, the basic controls, and the points obtained by feeding each Chicken. The Lives and Score are updated in real time via the “GameManager” which, for example, makes the Heart Images disappear. Once the player runs out of Lives, a "Game Over!" text is also displayed in the centre of the screen.

### 28/03/2023 - JumpGameFederico.unitypackage
Today I started Unit 3, completing Unit 3.1. The file I exported at the moment includes a Player who is able to jump by pressing the 'SpaceBar', and Obstacles that spawn and move to the left towards the player, with regular time intervals. The Player and the Obstacles have both Box Colliders and Rigidbodies.

### 17/04/2023 - TestPracticeFederico.unitypackage

### 18/04/2023 - MidTermFede.unitypackage

### 25/04/2023 - JumpGame2Federico.unitypackage
In today's class I completed Unit 3.2 and 3.3, adding a moving looping backgound, the disappearance of obstacles after they go outside of the screen, and the animations for the Player for Running, Jumping and Crashing. If the Player collides with an obstacle, the background and the spawning obstacles stop.

### 25/04/2023 - JumpGame3Federico.unitypackage
At home I completed Unit 3.4 adding music and sound effects that plays during the game and particle effects at the player’s feet and when he crash into an obstacle. I also completed all the following bonus features. I modified the spawn of obstacles, adding a random spawn among 4 different prefabs. I gave the Player the ability to perform a double jump, to avoid the higher obstacles. I added the ability to run faster by holding down the Shift key, which works by speeding up player animations, background movement, and obstacle spawn. I also added an animation to the player that occurs the moment the game starts. Finally, I added a UI that describes the controls of the game, and shows a score that increases based on how far you can get in the game.

### 26/04/2023 - TestFedeFinished.unitypackage
To practice at home, I finished and modified the test we did in class. I implemented the working GameOver() function, solving the static element problem by creating a variable "public static GameManager instance;" inside the GameManager script, which is used by external classes with "GameManager.instance.Method()".
I also added two different GameOver texts, the first one is shown if the player has run out of lives, and the other if an animal reaches the bottom of the screen and escapes.
In addition, I refined the function that makes the Mushroom appear, and I inserted the Antidote spawn. The function “spawnMushroom()” spawns the two items one at a time, in a random time frame that increases the spawn probability “mushVariable” as time goes on, and checks if the previous Mushroom or Antidote has appeared and has been collected by the player (to avoid for example, spawning the Antidote before the Mushroom has been collected).
Finally, I modified the UI adding text describing the game mechanics, what each Animal can eat, and I added a text that appears and disappears if the player has eaten the Mushroom, suggesting to grab the Antidote.

### 16/05/2023 - FinalProjectFederico.unitypackage
