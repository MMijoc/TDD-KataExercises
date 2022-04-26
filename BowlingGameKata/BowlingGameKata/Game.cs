using System;

namespace BowlingGameKata;

public class Game
{
	private int _score = 0;
	public void Roll(int pins)
	{
		_score += pins;
	}

	internal int Score()
	{
		return _score;
	}
}
