# Bowling Game Kata

## Instructions ##
This kata is designed to help you learn test-first coding and refactoring.

### Bowling Game Rules ###
A bowling game is split into 10 frames. During every frame player tries to knock down 10 pins. Each frame has maximum of two rolls (throws), but it can have only one roll if all 10 pins are knocked down in the first roll. 10th frame can have 3 rolls if a Spare or a Strike has occurred.

A score for any given frame is the sum of knocked down pins in that frame, however there are two scenarios where the score is calculated differently, those are:
1. Strike
- Strike happens if a player knocks down all 10 pins with the first roll in a frame, score for that frame is then calculated as 10 plus sum of knocked down pins in the next two rolls (from the next frame or even next two frame if next roll is also a Strike)
2. Spare
- Spare happens if a player knocks down all 10 pins with two rolls in a frame, score is then calculated as 10 plus number of pins knocked down in the next roll (that roll will be from the next frame)

If the 10th frame is a Spare then player has additional roll to determine the score of that Spare; the last roll is used only in the Spare score and and as such does not count towards the total score by itself.  
If the 10th frame is a Strike the plyer has additional two rolls to determine the score of a Strike; that last two rolls are used only to determine Strike score and as such do not count towards the total score by themselves.  

Total game score is the sum of scores from each frame.  
Maximum number of rolls is 21 (if a Spare or a Strike occurs in the last frame).  
Minimum number of rolls is 12 (if every frame is a Strike).  
Maximum score is 300 and it can happen only in a game with minimal number of rolls that is if every frame is a Strike.  

#### Examples ####
Example 1:
- 1st frame:
	- 1st roll: 5 pins
	- 2nd roll: 2 pins
		- Frame score: 7   

Example 2:
- 1st frame:
	- 1st roll: 5 pins
	- 2nd roll: 5 pins
	- **SPARE**
	    - Frame score: 10 + 3 = 13
- 2nd frame:
	- 1st roll: 3 pins
	- 2nd roll: 4 pins
		- Frame score: 7
		- Total score: 20  


Example 3:
- 1st frame:
	- 1st roll: 10 pins
	- **STRIKE** -> no second roll
		- Frame score: 10 + 3 + 4 = 17
- 2nd frame:
	- 1st roll: 3 pins
	- 2nd roll: 4 pins
		- Frame score: 7
		- Total score: 24  

Example 4:
- 1st frame:
	- 1st roll: 10 pins
	- **STRIKE** -> no second roll
		- Frame score: 10 + 10 + 3 = 23
- 2nd frame:
	- 1st roll: 10 pins
	- **STRIKE** -> no second roll
		- Frame score: 10 + 3 + 4 = 17
		- Total score: 23 + 17 = 40
- 3rd frame:
	- 1st roll: 3 pins
	- 2nd roll: 4 pins
		- Frame score: 3 + 4 = 7
		- Total score: 40 + 7 = 47  

Example 5:
- 10th frame (all other frames were 0):
	- 1st roll: 10 pins
	- **STRIKE** -> no second roll
		- Frame score: 10 + 3 + 4 = 17
- Two additional rolls:
    - 1st roll: 3 pins
    - 2nd roll: 4 pins
		- Total score: 17

Example 6:
- 10th frame (all other frames were 0):
	- 1st roll: 5 pins
	- 2nd roll: 5 pins
	- **SPARE**
		- Frame score: 10 + 3 = 13
- One additional roll:
    - 1st roll: 3 pins
		- Total score: 13  