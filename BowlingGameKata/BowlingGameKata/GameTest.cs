using System;
using Xunit;

namespace BowlingGameKata;

public class GameTest
{
	private readonly Game _game = new ();

	private void RoleMultiple(params int[] pinsDown)
	{
		if (pinsDown.Length > 21)
		{
			throw new ArgumentOutOfRangeException("Maximum number of throws in 21");
		}

		for (int i = 0; i < pinsDown.Length; i++)
		{
			_game.Roll(pinsDown[i]);
		}
	}

	[Fact]
	public void CanScoreGutterGame()
	{
		RoleMultiple(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

		Assert.Equal(0, _game.Score());
	}

	[Fact]
	public void CanScoreGameOfOnes()
	{
		RoleMultiple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

		Assert.Equal(20, _game.Score());
	}

	[Fact]
	public void CanScoreSpareFollowedBy3()
	{
		RoleMultiple(5, 5, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		// Score from the first frame is 13, and score from the second frame is 3
		// Total score is 16

		Assert.Equal(16, _game.Score());
	}

	[Fact]
	public void CanScoreStrikeFollowedBy3And3()
	{
		RoleMultiple(10, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		// Score from the first frame is 16, and score from the second frame is 6
		// Total score is 22

		Assert.Equal(22, _game.Score());
	}


}
