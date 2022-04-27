# TDD-KataExercises
This is my repository for practicing TTD using Kata.

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


# String Calculator Kata #

## Instructions ##

This kata is designed to help you learn test-first coding and refactoring. To that end, try not to read ahead or guess what the next requirements might be. Work incrementally, and complete as many steps as you can in a 30 minute period. Continue trying the kata from scratch, until you can complete it entirely within 30 minutes.

## Steps ##

1. Create a StringCalculator with a method Add(string numbers) that returns an integer.
	1. Start with the simplest test case of an empty string, then 1 number, then 2.
	2. Solve things as simply as possible!
	3. An empty string should return a sum of 0.
	4. *numbers* can include 0, 1, or 2 integers (e.g. "", "1", "1,2").
	5. Add returns the sum of the integers provided in the string *numbers*.
	6. Remember to refactor after each test.
2. Allow the Add method to handle an unknown number of numbers (in the string).
3. Allow the Add method to handle new lines between numbers (as well as commas):
	1. Example: "1\n2,3" returns 6.
	2. Example: "1,\n" is invalid, but no need to test for it. For this kata we are only concerned with testing correct inputs.
4. Allow the Add method to handle a different delimiter:
	1. To change the delimiter, the beginning of the string should be a separate line formatted like this: "//[delimiter]\n[numbers]"
	2. Example: "//;\n1;2" returns 3 (the delimiter is ";").
	3. This first line is optional; all existing scenarios (using "," or "\n") should work as before.
5. Calling Add with a negative number will throw an exception "Negatives not allowed: " and then listing all negative numbers that were in the list of numbers.
	1. Example: "-1,2" throws "Negatives not allowed: -1".
	2. Example: "2,-4,3,-5" throws "Negatives not allowed: -4,-5".
6. Numbers greater than 1000 should be ignored.
	1. Example: "1001,2" returns 2.
7. Delimiters can be any length, using this syntax: "//[|||]\n1|||2|||3" returns 6.
8. Allow multiple delimiters, using this syntax: "//[|][%]\n1|2%3" returns 6.
9. Handle multiple delimiters of any length.

## Resources ##
- This Kata was taken from Ardalis on github: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)
- [Original Version by Roy Osherove](http://osherove.com/tdd-kata-1/)
