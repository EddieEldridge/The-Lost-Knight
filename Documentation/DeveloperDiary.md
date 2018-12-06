![](https://raw.githubusercontent.com/EddieEldridge/The-Lost-Knight/master/Documentation/img/TheLostKnight.png)


<p align="center">
  <b>This is a development diary for my Unity project, The Lost Knight. This diary will be used to keep track of development and to outline my thoughts and ideas along the development process. This diary was maintained throughout the development of the game, evidence of this can be found <a href="https://github.com/EddieEldridge/The-Lost-Knight/commits/master/Documentation/DeveloperDiary.md">here.</a>
</b><br>
</p>

<p align="center">
<a href="https://github.com/EddieEldridge/The-Lost-Knight">You can track the development of this project here.</a>
</p>

# Main features
* Basic movement (Jumping, Walking, Dashing)
* Attacking (Melee and ranged attacking)
* Custom tilemap 
* Custom level backgrounds, sprites and particle effects
* 4 Levels including a tutorial level and a boss level
* Player progression stored in local storage (Coins, Levels Completed)
* Custom animations (Dashing, meleee attacking, ranged attacking, jumping, walking)
* [8 Bit Chiptune Soundtrack ](https://www.youtube.com/watch?v=k_Fpi1Zg7zY&list=PLwMEA8lwW6nGH5k0G1sdUxAMb7hs7VUW-)
* Sound effects
* Vibration effects
* Particle effects
* Menu's for settings, main menu, choosing levels and trading
* Economy system with persistence gold and a merchant NPC where gold can be spent on upgrades
* Enemy patrolling and chasing behaviour
* Player health and stamina bars that update dynamically
* Soft lighting effects
* Custom UI
* Touch controls
* Social Features (Login, Logout from Facebook, Send game invites via Facebook, Share the game via Facebook)


## 7th October, 2018
This is the first entry in my developer diary. This diary will be kept to keep track
of the development of The Lost Knight. All code will be published here on this
Github repository. So far, I have a basic player and some platforms. I can move the
player using touch buttons which I have placed on the bottom of the screen.

The player can also shoot using a script which I wrote for my previous game 'Hattori' which I had already started on before being assigned this game.
I also spent a considerable amount of time working on the movement aspects of my first Unity game 'Zephyr'. I hope that I am able to successfully use some of these scripts such as moving platforms and more advanced player movement such as ascending slopes, being able to stick to walls and being able to jump from walls. 

My plan for today is try and implement these movement features from Zephyr into The Lost Knight and to also get a nice camera movement system for following the player.

## 8th October, 2018
Yesterday I tried to implement the movement features from Zephyr into The Lost Knight. However, I realized it would take a large amount of work to refactor everything to work with The Lost Knight and I realized that a lot of it wasn't really necesasry. While Zephyr's main focus was on the movement aspect of the game, I don't feel like this is necessary to implement into The Lost Knight. Thing's like moving platforms and wall jumping/wall sliding don't really have a place in a 2D Action game and it also wasn't specified in the design document so I have chosen to exclude these features and focus instead on other aspects of the design.

I did however manage to implement some nice camera movement into The Lost Knight with a simple one line script. It has a nice smoothing effect which can be adjusted and I am happy with it.

Today I hope to be able to make a sprite so I can start work on melee attacking and and animations for attacking and dashing as these are core gameplay mechanics and should be started on sooner rather than later.

<b>Update</b>
I managed to successfully make a sprite I was happy with along with an extremely basic 2 frame walking animation that currently looks awful but I will put more time into later. My idea for the sprite is that the player character will be monochrome and the backgrounds of each level will be unique and have a distinct color theme. This is to give the idea that the knight is 'lost' as the world he is currently in his very different from his own, hence the color contrasts.

## 9th October, 2018
Yesterday we created a player sprite and did a very awful walking animation. Today I would like to separate the player's sword from the model so it can have it's own collider and so it can be more easily animated. I also hope to set this up so that when the player hit's the attack button, their sword will swing and damage the enemy. I already have code for this but with the arrow projectile so hopefully this will be easy enough to implement.

## 10th October, 2018
Yesterday I successfully managed to implement a melee attack and a corresponding button for melee attacking. I was happy with the way it turned out with an easily adjustable attack radius. I will need to include an animation and some blood effects so it's easier for the player to know if they registered a hit or not. I could also try knocking back the enemy or making them stop their movement to better portray this.

Today I have a short break in which i'd like to get the enemy movement working correctly. In Hattori, the enemies just moved directly down but in The Lost Knight I'm going to have to give them some kind of behaviour.

<b>Update</b>
I have a new sprite for the player's sword that is larger making it easier to see. This is important as it will be the player's main weapon. I also have made enemies move between two points to simulate some kind of patrol behaviour. The next step for enemy behaviour will be to implement a script that moves the enemy towards the player when the player enters the enemies patrol 'radius'.

<b> Update 2 </b>
I feel like a lot of my code is a bit of mess so i'm going to go through and refactor/clean up the whole project before I proceed as I feel like this will only cause more problems down the road.

## 11th October, 2018
Today I successfully managed to refactor a lot of the code so that going forward my project and scripts are laid out in a more structured way. This will make it easier to add new components to the game without spending hours implementing them. I've also added a health bar system so for testing I can more acccurately see what's going.

## 16th October, 2018
I added some lighting effects and re-wrote some of the code. I still need to add attack animations and do some bug fixing on my attacking. I also need to add enemy patrolling and attacking. Once this is done, I can start on level design and then on enemy design. I hope to have this ready for the deadline on the 13th of November.

## 17th October, 2018
Now that i've added patrolling and chasing behaviour to the enemies it's time to work on animating the player and adding some particle effects to make the player's attack's feel more impactful. I would like to do this as this was a specific feature that was specified in the design document. To do this, I would like to add a blood particle effect that happens when the enemy is hit as well as knocking the enemy back a small bit when they are hit. This should let the player know when they have connected with their attack. I would also like to add an exclamation mark above enemies heads when the player comes within their aggro range. This should let the player know that the enemies have seen them and are going to attack them.

## 22th October, 2018
I've sucessfully added a game background for the tutorial level which I can use as a template for all other levels. I also have a blood animation/particle effect that plays when an enemy is hit. The next plan is to work on a pause menu that will display player's information such as their XP level, health and give them options for exiting the game and settings.

## 5th November, 2018
Since my last entry in my developer diary I have added quite a few new features. I have redesigned the whole UI to give it more of a cohesive them as well as adding new main menu, music and a pause menu. I've also added dashing and blood particles as well as some lighting effects using soft brushes made in Photoshop. I am very happy with how the game is looking so far. I've also added coins that the player can pick up and spend in shops in the game. I think I will keep the shop simple, instead of changing gameplay i'm thinking it will just offer customiziation options such as color change or weapon change but this probably won't affect gameplay too much. Next I would like to finish the tutorial level design as well as adding the shop. 

## 6th November, 2018
I have managed to successfully add a shop which was part of the design brief for the game. The player can approach a merchant character upon which a prompt to trade will appear. They can then touch the merchant to begin trading. They are then greeted with some options regarding what things they can spend their gold on as well as how much it will cost. I would like to expand on what options are available from the shop but at the moment I just want to focus on completing the game in general.

## 8th November, 2018
I have added a splash screen as well as some an options menu with no functionality yet. I have also expanded upon the tutorial design. I am getting close to finishing the first level, I just need to fix some small bugs with movement and add a ranged attack to the Wraith enemy. Then I can start designing and building the levels outlined in the design document.

## 17th November, 2018
So far, the game has the following features

#### Implemented
* Movement (Dashing, Jumping, Walking/Running)
* Health and Stamina system with corresponding bars
* Ranged and melee attacks
* Enemies that move patrol and chase the player when the player moves close to them
* Main menu, pause menu and settings menu with corresponding buttons and functionality
* Android touch controls
* Lighting and particle effects
* Appropriate sprites for all corresponding game objects
* Music and sound effects for player actions/levels
* Custom tilemap for level generation
* One fully complete tutorial
* Merchant and gold system

#### To be implemented
* Animations
* Three more levels
* Ranged enemies
* Saving player information in local storage
* Social media/online functionality
* Submission to Play store

There are roughly 2 and a half weeks before the deadline (6th of December). I hope to have the above features implemented by the 31st of November and spend the rest of the time before the deadline bug fixing/polishing the game and preparing it for submission to the Play store.

## 19th November, 2018
I have successfully added walking and idle animations for the player character and I am happy with them. I am also saving the player's gold amount in local storage so when they open up the game after closing it they will have the same gold. This also means gold will carry into the next level where the merchant will have more expensive upgrades.

## 22nd November, 2018
I've updated the build to version 0.7. This new build includes some social media integration with Facebook. The player can now login and logout with Facebook, invite friends to play the game and share the game with other Facebook friends. I've also uploaded the game to the Play Store and hopefully it will be available soon. The game isn't 100 percent finished but I want to get it on the Play Store now rather than later as a lot of the Facebook social integration requires a Play Store link to work properly. I still have to add some attacking, dashing and jumping animations as well as make some more levels. 

## 25 November, 2018
Today, i've added a second level to the game as well as updating the game on the Play store. I've done some beta testing by giving the game out to some friends through the Play store link and I have been told that there are several bugs in the game such as 

<strike>

* Sometimes the player gets stuck jumping and can't get out of this state
* Death sequence sometimes doesn't trigger properly
* Gold/Items not updating properly at the merchant
* Not enough levels
* Slimes don't die properly
* Arrows not showing a hit 

I need to fix these problems as they are quite bad.

</strike> 

## 30th November, 2018
I've fixed all the bugs present above and also added a new level in called the Hallowed Cave. I'm pretty much done at this stage, I just need one more level, the boss level and the game is finished. I also need to update the build on the Play Store as it contains a lot of the bugs listed above. 

# Testing
Below are some details of how I tested my game

### Unit Testing
I have played each level through thoroughly and tested a lot of scenarios to ensure that everything was working correctly for each level.

### Integration Testing
I then played the game from start to finish, to ensure that every level worked correctly when playing the game from start to finish in one sitting. This was to ensure that no variables were being distorted between levels or any weird behaviour was occurring.

### Beta Testing
I published the game on the app store and sent out the link to some of my friends who kindly tested the game and reported back any of the bugs they found. They found the following bugs

* Sometimes the player gets stuck jumping and can't get out of this state
* Death sequence sometimes doesn't trigger properly
* Gold/Items not updating properly at the merchant
* Not enough levels
* Slimes don't die properly
* Arrows not showing a hit 

I was able to pretty much fix all of these but it was important that I did the beta testing as I wouldn't have found out that the bugs existed otherwise.

### System Testing
I deployed the game to my Android phone and tested it to make sure there no problems when running on the target platform. I had a small issue with images not being displayed properly on my Android device and I realized quickly it was due to them not having an image component but just a sprite renderer. Apart from that everything worked surprisingly well.

### Acceptance Testing
I sent the designer of the game, Donal Burke, a link to the app and he tested the game and said he was happy with it and that were no changes he would like to make to the game.

### End
As the designer was happy with the product, I ended my testing.

## 2nd December, 2018
I've updated the build on the Play store to version 0.9. This new update includes all the bug fixes detailed above as well as adding 2 new level, one of which includes the boss level. Below, I am going to outline all the features I have implemented so far as a summary of the development of this project. I am very happpy with how the game turned out. 

## 6th December, 2018
I've updated the APK on the Play store to Version 1.1 which includes some bugfixes as well as some minor changes to the levels.

### Known Bugs
* Sometimes the player will randomly stop moving
* The merchant on the boss level doesn't work correctly in certain situations
* Arrows don't show a hit effect even though they are damaging the enemy

### What would I do differently?
* Use a state machine to control player and enemy states
* Use a singleton controller to keep track of game-wide variables/states
* Implement game functionality in a cleaner, less convuluated way
* Spend more time getting game mechanics down rather than making the game look nice
