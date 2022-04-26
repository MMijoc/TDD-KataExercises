using Xunit;

namespace BowlingGameKata;

public class GameTest
{
	[Fact]
	public void CanScoreGutterGame()
	{
		Game game = new Game();

		for (int i = 0; i < 20; i++)
		{
			game.Roll(0);
		}

		Assert.Equal(0, game.Score());
	}
}
