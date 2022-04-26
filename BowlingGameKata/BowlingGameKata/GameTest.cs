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


}
