using Xunit;

namespace BowlingGameKata;

public class GameTest
{
	[Fact]
	public void CanRollBall()
	{
		Game game = new Game();
		game.Roll(0);
	}

}
