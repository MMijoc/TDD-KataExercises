using System;

namespace BowlingGameKata;

public class Game
{
	private int[] _rolls = new int[21];
	private int _currentRoll = 0;
	public void Roll(int pins)
	{
		_rolls[_currentRoll] = pins;
		_currentRoll++;
	}

	internal int Score()
	{
		int score = 0;
		int cursor = 0;
		for (int frame = 0; frame < 10; frame++)
		{
			if (IsStrike(cursor))
			{
				score += 10 + _rolls[cursor + 1] + _rolls[cursor + 2];
				cursor++;
			}
			else if (IsSpare(cursor))
			{
				score += 10 + _rolls[cursor + 2];
				cursor += 2;
			}
			else
			{
				score += _rolls[cursor] + _rolls[cursor + 1];
				cursor += 2;
			}
		}

		return score;
	}

	private bool IsStrike(int cursor)
	{
		return _rolls[cursor] == 10;
	}

	private bool IsSpare(int cursor)
	{
		return _rolls[cursor] + _rolls[cursor + 1] == 10;
	}
}
