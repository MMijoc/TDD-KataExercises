using System;

namespace BowlingGameKata;

public class Game
{
	private int[] _rolls = new int[21];
	private int _currentRolle = 0;
	public void Roll(int pins)
	{
		_rolls[_currentRolle] = pins;
		_currentRolle++;
	}

	internal int Score()
	{
		int score = 0;
		int cursor = 0;
		for (int frame = 0; frame < 10; frame++)
		{
			if (_rolls[cursor] + _rolls[cursor + 1] == 10)
			{
				score += 10 + _rolls[cursor + 2];
			}
			else
			{
				score += _rolls[cursor] + _rolls[cursor + 1];
			}
			cursor += 2;
		}

		return score;
	}
}
