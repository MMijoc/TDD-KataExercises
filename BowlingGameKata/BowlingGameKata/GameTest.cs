using Xunit;

namespace BowlingGameKata;

public class GameTest
{
	[Fact]
	public void CanMakeGame()
	{
		Game game = new Game();

		Assert.NotNull(game);
	}

	[Fact]
	public void CanRollBall()
	{
		Game game = new Game();
		game.Roll(0);
	}

}
