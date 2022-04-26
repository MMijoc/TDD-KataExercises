using Xunit;

namespace BowlingGameKata;

public class GameTest
{
	private readonly Game _game = new ();

	private void RoleMultiple(int n, int pinsDown)
	{
		for (int i = 0; i < n; i++)
		{
			_game.Roll(pinsDown);
		}
	}

	[Fact]
	public void CanScoreGutterGame()
	{
		RoleMultiple(20, 0);

		Assert.Equal(0, _game.Score());
	}

	[Fact]
	public void CanScoreGameOfOnes()
	{
		RoleMultiple(20, 1);

		Assert.Equal(20, _game.Score());
	}

	[Fact]
	public void CanScoreSpareFollowedBy3()
	{
		// Spare in the first frame
		_game.Roll(5);
		_game.Roll(5);

		// 3 pins in the second frame
		_game.Roll(3);

		RoleMultiple(17, 0);
		// Score from the first frame is 13
		// Score from the second frame is 3
		// All other frames have score of 0
		// total score is 16

		Assert.Equal(16, _game.Score());
	}


}
