using Xunit;

namespace FizzBuzzKata;

public class FizzBuzzTest
{
	[Fact]
	public void CanCreateNewFizzBuzz()
	{
		FizzBuzzer fizzBuzz = new FizzBuzzer();
		fizzBuzz.FizzBuzz();
	}
}
