# Unity Projects: Junior Programmer Pathway

Collection of Unity Projects completed as part of the "Unity Junior Programmer Pathway" during the 3D Game Development course at University of Debrecen, led by [Dr. Kruppa Kinga Tünde](https://inf.unideb.hu/en/dr-kinga-tunde-kruppa), from February 2023 to June 2023. Each project represents a complete game developed in different units, showcasing the skills and concepts learned along the way.

For a detailed breakdown of updates, changes, and submitted Unity packages after each lesson, please refer to the [ChangeLogs](https://github.com/FedeDC512/unity-projects/blob/main/ChangeLogs.md). This log provides a detailed timeline of all updates made throughout the course, with each unitypackage linked to its corresponding submission date.

<p align="center">
  <a href="https://learn.unity.com/pathway/junior-programmer" target="_blank">
    <img src="https://images.credly.com/images/03d1c2f6-6182-49bd-b5af-2ef6d28b5383/image.png" alt="Junior Programmer Pathway" style="width:200px;height:auto;">
  </a>
</p>

## Game Projects List
- [Car Game with Multiplayer Mode](#prototype-1-car-game-with-multiplayer-mode-unit-1---player-control)
- [Space Chickens](#prototype-2-space-chickens-unit-2---basic-gameplay)
- [Hero vs Slime](#test-practice-hero-vs-slime)
- [Enhanced Animal Feeder Game](#mid-term-enhanced-animal-feeder-game)
- [Endless Runner Game](#prototype-3-endless-runner-game-unit-3---sound-and-effects)
- [Small Animals' Worth](#final-project-small-animals-worth)

## Prototype 1: Car Game with Multiplayer Mode ([Unit 1 - Player Control](https://learn.unity.com/project/unit-1-driving-simulation))
In this project, I created a simple car game where the player controls a blue car moving side-to-side on a floating road, avoiding obstacles. The main camera follows the car and can shift position with the left CTRL key, adjusting slightly with the car's rotation. I also added green cars that move towards the player, scattered obstacles with rigid bodies, and a multiplayer mode. Pressing "1" splits the screen for two players, each with their own controls and camera. On-screen instructions update dynamically depending on whether multiplayer is active. 

This unit focused on basic Unity editor usage, C# scripting, and foundational programming concepts like functions and variables.

![game1.png](https://github.com/FedeDC512/unity-projects/blob/main/images/game1.png)

## Prototype 2: Space Chickens ([Unit 2 - Basic Gameplay](https://learn.unity.com/project/unit-2-basic-gameplay))
In this project, I developed a top-down Animal Feeder Game, where the player throws corn bullets to feed chickens, chicks, and roosters that charge toward them. The animals spawn randomly from different directions and have varying speeds and hunger bars that need to be filled to make them disappear. Each successful feeding increases the player's score, while colliding with animals decreases the player's lives. Once lives run out, the game ends.

Key concepts covered include if-then statements, random value generation, arrays, collision detection, prefabs, and instantiation. The game demonstrates basic projectile mechanics and player movement.

![game2.png](https://github.com/FedeDC512/unity-projects/blob/main/images/game2.png)

## Test Practice: Hero vs Slime
Test Practice is a preparation test for the Mid Term, featuring a game where a hero moves around an enemy slime. The hero can shoot bullets that automatically track and move towards the slime. This project is designed to reinforce gameplay mechanics and combat interactions.

![test.png](https://github.com/FedeDC512/unity-projects/blob/main/images/test.png)

## Mid Term: Enhanced Animal Feeder Game
In this Mid Term project, I expanded the Animal Feeder game by adding new mechanics. Different animals now require specific foods, and the player must ensure they throw the correct food. Player movement can become inverted by a Mushroom, and the player must find an Antidote to restore normal controls. The game ends if an animal escapes the screen or if the player feeds the wrong food three times.

![midterm.png](https://github.com/FedeDC512/unity-projects/blob/main/images/midterm.png)

## Prototype 3: Endless Runner Game ([Unit 3 - Sound and Effects](https://learn.unity.com/project/unit-3-sound-and-effects))
In this project, I developed an endless side-scrolling runner game where the player jumps over obstacles to avoid crashing. The game includes a dynamic looping background, player animations for running, jumping, and crashing, and obstacles that spawn randomly at regular intervals and disappear off-screen. If the player crashes, the game stops. Gameplay is improved with double jump mechanics, music, sound effects, particle effects, and the ability to run faster by holding Shift. 

The unit introduced adding music and sound effects, creating dynamic endless backgrounds, and incorporating particle effects for a more engaging gameplay experience.

![game3.png](https://github.com/FedeDC512/unity-projects/blob/main/images/game3.png)

## Final Project: [Small Animals' Worth](https://github.com/FedeDC512/SmallAnimalsWorth)
Small Animals' Worth is the Final Project I developed for the course. In this game, tiny animals battle against larger ones across three progressively harder levels, each with a different theme and animals. Players can choose to heal or attack while facing opponents with three types of attacks: regular health reduction, bullet hell dodging with objects, and summoning attacks that trigger more bullet hell challenges. The goal is to reduce the enemy's health bar to zero to win. This project integrates advanced Unity concepts, including complex enemy behavior, level progression, and strategic gameplay mechanics.

> The full project and code are available in a separate repository. You can find the complete project [here](https://github.com/FedeDC512/SmallAnimalsWorth).

![level.gif](https://github.com/FedeDC512/SmallAnimalsWorth/blob/main/images/level.gif)
