# Yahtzee in C#
Yahtzee with an UI built with C# (2020)

- [Explication](#explication)
- [UI](#ui) 
  * [Overall explained](#overall-explained)
  * [Dice](#dice)
  * [Gamecard](#gamecard)
  * [Interactions](#interactions)
  * [End of the game](#end-of-the-game)
  * [Scoreboard](#scoreboard)
- [How to play](#how-to-play)  
  
  
## Explication
This project was my first project at all with C#. I already did some work with Java so it wasn't to difficult. 
I decided to realise this Yahtzee UI to show an example of a beginner project and my terms of programming.
  
> The objective of **Yahtzee** is to score points by rolling five dice to make certain combinations. The dice can be rolled up to three times in a turn to try to make various scoring combinations and dice must remain in the box. A game consists of thirteen rounds. After each round the player chooses which scoring category is to be used for that round. Once a category has been used in the game, it cannot be used again. The scoring categories have varying point values, some of which are fixed values and others for which the score depends on the value of the dice. A Yahtzee is five-of-a-kind and scores 50 points, the highest of any category. ( -Wikipedia)
  
  
## UI
The UI was created with Windows-Form-App (.NET Framework).

![UI Overall](https://i.ibb.co/4WP7BwS/ui.png)


### Overall explained
![UI Overall explained](https://i.ibb.co/gDZJrvH/ui-Kopie.png)

>*1. Formular to choose the number of games to play (1-4) [before the game]*

>*2. Section of the dice*

>*3. Formular to keep rolling the dice or stop if the result is wanted*

>*4. Formular to decide where to put the result and in which game*

>*5. Section of the Gamecard*

>*6. Button to show the Scoreboard*


### Dice

![Dice](https://i.ibb.co/fqDw0nZ/dice.png)

> Click on the dice you want to keep. 

> You can undo it with clicking again. 

> The selection is reset on every attempt.


### Gamecard

![Gamecard](https://i.ibb.co/Vm2czPK/gamecard.png)


### Interactions

![Insert result](https://i.ibb.co/BCk4ZsS/insert1.png)

> If you can insert the result you have to choose what to take 

> Then choose the game number and press **OK**


![Cross out](https://i.ibb.co/tsHJHkw/insert.png)

> If you cannot insert anywhere you have to **cross out**

> After choosing the game number you will see a new cross out select form

> You choose what to cross out and press **OK** (in the Gamecard it will be represented by a "-")


### End of the game

![End of the game](https://i.ibb.co/0ZDm3mb/end.png)

> Your total score, average score and number of yahtzees are shown (more details in the scoreboard) 

> You can decide if you want to continue to play (a new round)

> Or if you want to quit the application


### Scoreboard

![Scoreboard](https://i.ibb.co/s1sNWgc/score.png)

> Multiple statistics: Game number, number of games, average of upper section points, average of lower section points, average points and total points


## How to play

> Choose the game number and press **PLAY** *(Gamecard will be generated)*

> You roll the dice and insert the results with the formular 

> That's all !


*2020 © Janos Falke*
